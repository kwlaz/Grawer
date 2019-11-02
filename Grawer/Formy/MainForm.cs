using Grawer.Formy;
using Grawer.Kontrolki;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grawer
{
    public partial class MainForm : Form
    {
        Point czerwony_pm=new Point(0,0);        
        int przesuniecie,myszX,myszY;
        ArdCon arduino = new ArdCon();
        
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
       (
           int nLeftRect,    
           int nTopRect,     
           int nRightRect,   
           int nBottomRect,   
           int nWidthEllipse, 
           int nHeightEllipse 
           
       );


        public MainForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            obraz.Visible = true;
            //obraz1.AllowDrop = true;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

        }

        private void mouseEnterZM(object sender, EventArgs e)
        {
            Label klik_Label = (Label)sender;
            if (klik_Label == null) 
                return;

            if (klik_Label.Text == "X")
            {
                klik_Label.ForeColor = Color.Cornsilk;
            }
            else if (klik_Label.Text == "-")
            {
                klik_Label.ForeColor = Color.Cornsilk;
            }
        }

        private void mouseLeaveZM(object sender, EventArgs e)
        {
            Label klik_Label = (Label)sender;
            if (klik_Label == null)
                return;

            if (klik_Label.Text == "X")
            {
                klik_Label.ForeColor = Color.Black;
            }
            else if (klik_Label.Text == "-")
            {
                klik_Label.ForeColor = Color.Black;
            }
        }

        private void xlabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void _label_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void gornypanel_MouseDown(object sender, MouseEventArgs e)
        {
            przesuniecie = 1;
            myszX = e.X;
            myszY = e.Y;
        }

        private void obrazButton_Click(object sender, EventArgs e)
        {
            czerwony_pm.Y = 100;
            czerwonyPanel.Location = czerwony_pm;
            obraz.Visible = true;
            parametry.Visible = false;
            pozycjonowanie.Visible = false;
            podsumowanie.Visible = false;
        }

        private void paramertryButton_Click(object sender, EventArgs e)
        {
            czerwony_pm.Y = 150;
            czerwonyPanel.Location = czerwony_pm;
            obraz.Visible = false;
            parametry.Visible = true;
            pozycjonowanie.Visible = false;
            podsumowanie.Visible = false;

        }

        private void polaczenieButton_Click(object sender, EventArgs e)
        {
            pozycjonowanie.ustawArd(arduino);
            czerwony_pm.Y = 200;
            czerwonyPanel.Location = czerwony_pm;
            pozycjonowanie.Visible = true;
            obraz.Visible = false;
            parametry.Visible = false;
            podsumowanie.Visible = false;
            

        }

        private void grawerujButton_Click(object sender, EventArgs e)
        {
            if (Ustawienia.Caly_bmp != null)
            {
                czerwony_pm.Y = 250;
                czerwonyPanel.Location = czerwony_pm;
                pozycjonowanie.Visible = false;
                obraz.Visible = false;
                parametry.Visible = false;
                podsumowanie.Visible = true;
                podsumowanie.ustawArd(arduino);
                podsumowanie.ustawObraz();
            }
            else
            {
                MessageBox.Show("Brak obrazu");
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            Application.Exit();
        }

        private void gornypanel_MouseUp(object sender, MouseEventArgs e)
        {
            przesuniecie = 0;
        }

        private void gornypanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (przesuniecie == 1)
            {
                this.SetDesktopLocation(MousePosition.X-logopanel.Width - myszX, MousePosition.Y - myszY);
            }
        }
        
    }
}
