using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grawer.Formy
{
    public partial class Skala : Form
    {
        
        public Skala()
        {
            InitializeComponent();
            
        }


        
        private void ZatwierdzButton_Click(object sender, EventArgs e)
        {
            if (pikselRadioButton.Checked)
            {
                Ustawienia.Piksel_pion = Convert.ToInt16(pionTextBox.Text);
                Ustawienia.Piksel_poziom = Convert.ToInt16(poziomTextBox.Text);
                Ustawienia.Skala_status = 1;
            }
            if (procentRadioButton.Checked)
            {
               Ustawienia.Procent_pion = Convert.ToInt16(pionTextBox.Text);
               Ustawienia.Procent_poziom = Convert.ToInt16(poziomTextBox.Text);
               Ustawienia.Skala_status = 2;
            }
            this.Close();
        }

        private void pikselRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            pionTextBox.Text = "99999";
            poziomTextBox.Text = "999999";
        }

        private void procentRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            pionTextBox.Text = "100";
            poziomTextBox.Text = "100";
        }
    }
}
