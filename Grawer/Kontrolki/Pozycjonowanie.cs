using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO.Ports;

namespace Grawer.Kontrolki
{
    public partial class Pozycjonowanie : UserControl
    {
        private ArdCon arduino;
        private string[] porty_com;
        SerialPort port = new SerialPort();
        public Pozycjonowanie()
        {
            InitializeComponent();
          
            porty_com = SerialPort.GetPortNames();
            portyComboBox.Items.Clear();
            foreach(string p in porty_com)
            {                
                portyComboBox.Items.Add(p);
            }
        }
        
        
        private void Pozycjonowanie_Load(object sender, EventArgs e)
        {


        }

        
        private void skokRightArrowButton_MouseEnter(object sender, EventArgs e)
        {
            skokRightArrowButton.BackColor = Color.Red;
        }

        private void skokRightArrowButton_MouseLeave(object sender, EventArgs e)
        {
            skokRightArrowButton.BackColor = Color.Lime;
        }

        private void skokDownArrowButton_MouseEnter(object sender, EventArgs e)
        {
            skokDownArrowButton.BackColor = Color.Red;
        }

        private void skokDownArrowButton_MouseLeave(object sender, EventArgs e)
        {
            skokDownArrowButton.BackColor = Color.Lime;
        }

        private void skokLeftArrowButton_MouseEnter(object sender, EventArgs e)
        {
            skokLeftArrowButton.BackColor = Color.Red;
        }

        private void skokLeftArrowButton_MouseLeave(object sender, EventArgs e)
        {
            skokLeftArrowButton.BackColor = Color.Lime;
        }

        private void skokUpArrowButton_MouseEnter(object sender, EventArgs e)
        {
            skokUpArrowButton.BackColor = Color.Red;
        }

        private void skokUpArrowButton_MouseLeave(object sender, EventArgs e)
        {
            skokUpArrowButton.BackColor = Color.Lime;
        }

        private void skokTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
                   
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void skokUpArrowButton_Click(object sender, EventArgs e)
        {
            arduino.przesun("G91 G1 Y-",skokTextBox.Text);
        }
        private void skokRightArrowButton_Click(object sender, EventArgs e)
        {
            arduino.przesun("G91 G1 X", skokTextBox.Text);
        }

        private void skokDownArrowButton_Click(object sender, EventArgs e)
        {
            arduino.przesun("G91 G1 Y", skokTextBox.Text);
        }

        private void skokLeftArrowButton_Click(object sender, EventArgs e)
        {
            arduino.przesun("G91 G1 X-", skokTextBox.Text);
        }
        private void dezaktywuj()
        {
            skokDownArrowButton.Enabled = false;
            skokUpArrowButton.Enabled = false;
            skokLeftArrowButton.Enabled = false;
            skokRightArrowButton.Enabled = false;
        }
        private void aktywuj()
        {
            skokDownArrowButton.Enabled = true;
            skokUpArrowButton.Enabled = true;
            skokLeftArrowButton.Enabled = true;
            skokRightArrowButton.Enabled = true;
            
        }
        
        

        private void odswiezButton_Click(object sender, EventArgs e)
        {
            portyComboBox.Items.Clear();
            porty_com = null;
            porty_com = SerialPort.GetPortNames();
            foreach (string p in porty_com)
            {
                portyComboBox.Items.Add(p);
            }
        }
        int status_polaczenia = 0;
        private void polaczButton_Click(object sender, EventArgs e)
        {
            if (status_polaczenia == 0) {
                try
                {
                    arduino.polacz(portyComboBox.Text);
                    Ustawienia.PortCOM = portyComboBox.Text;
                    statusLabel.Text = "Połączono: "+portyComboBox.Text;
                    statusLabel.ForeColor = Color.Lime;
                    status_polaczenia = 1;
                    polaczButton.Text = "Rozlacz";
                    pozPanel.Visible = true;
                    konsolaPanel.Visible = true;
                }
                catch
                {
                    MessageBox.Show("Błąd połączenia");
                }
            }else if (status_polaczenia == 1)
            {
                statusLabel.ForeColor = Color.Red;
                status_polaczenia = 0;
                arduino.rozlacz();
                polaczButton.Text = "Połącz";
                statusLabel.Text = "Nie połączono";
                pozPanel.Visible = false;
                konsolaPanel.Visible = false;
            }
        }

        private void konsolTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            string t;
            if (e.KeyCode == Keys.Enter)
            {
                t = konsolTextBox.Text;
                ekrankonsoliTextBox.AppendText(t);
                ekrankonsoliTextBox.AppendText(Environment.NewLine);
                arduino.wyslij_komende(t);
                konsolTextBox.Text = "";
                
            }
        }
        public void ustawArd(ArdCon ard)
        {
            this.arduino = ard;
        }

        private void wyslijButton_Click(object sender, EventArgs e)
        {
            
            ekrankonsoliTextBox.AppendText(konsolTextBox.Text);
            ekrankonsoliTextBox.AppendText(Environment.NewLine);
            arduino.wyslij_komende(konsolTextBox.Text);
            konsolTextBox.Text = "";
        }
    }

}
