using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using Grawer.Formy;
using System.Globalization;

namespace Grawer.Kontrolki
{
    public partial class Obraz : UserControl
    {
        Boolean procentowo;
        Podglad podglad = new Podglad();
        float kat = 0;
        AlgPodglad algPodglad = new AlgPodglad();
        double proporcje;
        private Bitmap podgladBmp,alg_podgladBmp,caly_obrazBmp,suwakBmp,tmpBmp;     
        public Obraz()
        {
            InitializeComponent();
            algorytmComboBox.SelectedIndex = 0;
            Ustawienia.Wybranyalgorytm = 0;
            podgladPictureBox.AllowDrop = true;
            Ustawienia.Prog = progTrackBar.Value;

        }

        private void otworzButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fbd = new OpenFileDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    sciezkaLabel.Text = fbd.FileName;
                    podgladBmp = (Bitmap)Image.FromFile(sciezkaLabel.Text);
                    caly_obrazBmp = (Bitmap)Image.FromFile(sciezkaLabel.Text);
                    dopasuj();
                    alg_podgladBmp = podgladBmp;
                    suwakBmp = podgladBmp;
                    tmpBmp = podgladBmp;
                    podgladPictureBox.Image = podgladBmp;
                    Ustawienia.Piksel_pion = caly_obrazBmp.Height;
                    Ustawienia.Piksel_poziom = caly_obrazBmp.Width;
                    Ustawienia.Caly_bmp = caly_obrazBmp;
                    rozmiarObrazu();
                }
                catch
                {
                    MessageBox.Show("Nieprawidłowy plik");
                }
            }
        }
               
        private void podgladPictureBox_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                caly_obrazBmp = (Bitmap)Image.FromFile(files[0]);
                podgladBmp = (Bitmap)Image.FromFile(files[0]);
                sciezkaLabel.Text = files[0];
                dopasuj();
                alg_podgladBmp = podgladBmp;
                suwakBmp = podgladBmp;
                tmpBmp = podgladBmp;
                podgladPictureBox.Image = podgladBmp;                
                rozmiarObrazu();
            }
            catch
            {
                MessageBox.Show("Nieprawidłowy plik");
            }

        }

        

        private void lewoButton_Click(object sender, EventArgs e)
        {
            kat = 1;
            podgladBmp = (Bitmap)algPodglad.obrocObraz(podgladBmp, kat);
            podgladPictureBox.Image = podgladBmp;
            caly_obrazBmp = (Bitmap)algPodglad.obrocObraz(caly_obrazBmp, kat);
            rozmiarObrazu();
        }

        private void prawoButton_Click(object sender, EventArgs e)
        {
            kat = 0;
            podgladBmp=(Bitmap)algPodglad.obrocObraz(podgladBmp, kat);
            podgladPictureBox.Image = podgladBmp;
            caly_obrazBmp = (Bitmap)algPodglad.obrocObraz(caly_obrazBmp, kat);
            rozmiarObrazu();
        }

        private void podgladPictureBox_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        

        private void nowyButton_Click(object sender, EventArgs e)
        {
            podgladPictureBox.Image = null;
        }

        private void resetKontrastButton_Click(object sender, EventArgs e)
        {
            kontrastTrackBar.Value = 0;
            Ustawienia.Kontrast = 0;
        }

       

        private void resetJasnoscButton_Click(object sender, EventArgs e)
        {
            jasnoscTrackBar.Value = 0;
            Ustawienia.Jasnosc = 0;
        }

        private void jasnoscTrackBar_ValueChanged(object sender, EventArgs e)
        {
            Ustawienia.Jasnosc = jasnoscTrackBar.Value;
            suwakBmp=algPodglad.ustawJasnosc(jasnoscTrackBar, (Bitmap)podgladBmp.Clone());
            tmpBmp = suwakBmp;
            suwakBmp = algPodglad.ustawKontrast(kontrastTrackBar, (Bitmap)tmpBmp.Clone());
            podgladPictureBox.Image = suwakBmp;
        }

        private void wyspxTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {              

                e.Handled = true;


            }
        }

        private void szpxTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void wysTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void szeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
              e.Handled = true;
            }
        }

        private void wyspxTextBox_Validating(object sender, CancelEventArgs e)
        {            
            int piksele;
            try
            {
                piksele = Convert.ToInt16(wyspxTextBox.Text);
                if (piksele > 0)
                {
                    wysTextBox.Text = (Ustawienia.Rozdzielczosc*piksele).ToString();
                }
            }
            catch { }
            
        }

        private void szpxTextBox_Validating(object sender, CancelEventArgs e)
        {
            int piksele;
            try
            {
                piksele = Convert.ToInt16(szpxTextBox.Text);
                if (piksele > 0)
                {
                    szeTextBox.Text = (Ustawienia.Rozdzielczosc*piksele).ToString();
                }
            }
            catch { }
        }

        private void wysTextBox_Validating(object sender, CancelEventArgs e)
        {
            double wys;
            try
            {
                wys = Convert.ToDouble(wysTextBox.Text);
                if (wys > 0)
                {
                    wyspxTextBox.Text = Convert.ToInt16(wys/Ustawienia.Rozdzielczosc).ToString();
                }
            }
            catch { }
        }

        private void szeTextBox_Validating(object sender, CancelEventArgs e)
        {
            double sze;
            try
            {
                sze = Convert.ToDouble(szeTextBox.Text);
                if (sze > 0)
                {
                    szpxTextBox.Text = Convert.ToInt16(sze/Ustawienia.Rozdzielczosc).ToString();
                }
            }
            catch { }
        }

        private void podgladButton_Click(object sender, EventArgs e)
        {
            try
            {
                int index = algorytmComboBox.SelectedIndex;
                Ustawienia.Wybranyalgorytm = index;
                switch (index)
                {
                    case 0:
                        podglad.ustawObraz(algPodglad.stucki((Bitmap)(podgladPictureBox.Image).Clone(), progTrackBar.Value));
                        break;
                    case 1:
                        podglad.ustawObraz(algPodglad.floyd_Steinberg((Bitmap)(podgladPictureBox.Image).Clone(), progTrackBar.Value));
                        break;
                    case 2:
                        podglad.ustawObraz(algPodglad.progowe((Bitmap)(podgladPictureBox.Image).Clone(), progTrackBar.Value));
                        break;
                    default:
                        break;
                }
                podglad.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Brak obrazu");
            }
        }

        
        private void progTextBox_Validating(object sender, CancelEventArgs e)
        {
            progTrackBar.Value = Convert.ToInt16(progTexBox.Text);
        }

        private void progTexBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void progTexBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                progTrackBar.Value = Convert.ToInt16(progTexBox.Text);
            }
        }

        private void algorytmComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ustawienia.Wybranyalgorytm = algorytmComboBox.SelectedIndex;
        }

        private void progTrackBar_ValueChanged(object sender, EventArgs e)
        {
            progTexBox.Text = progTrackBar.Value.ToString();
            Ustawienia.Prog = progTrackBar.Value;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            procentowo = !procentowo;
        }

        private void rozdzielczoscTextBox_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                Ustawienia.Rozdzielczosc = Double.Parse(rozdzielczoscTextBox.Text, CultureInfo.InvariantCulture);
                rozmiarObrazu();
            }
            catch
            {

            }
        }

        private void rozdzielczoscTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void rozdzielczoscTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Ustawienia.Rozdzielczosc = Convert.ToDouble(rozdzielczoscTextBox.Text);
            }
        }

        private void dopasuj()
        {
            int pikselx=0, piksely=0;
            if ((podgladBmp.Height > podgladPictureBox.Height)||(podgladBmp.Width>podgladPictureBox.Width))
            {
                if (podgladBmp.Height > podgladBmp.Width)
                {
                    proporcje = Convert.ToDouble(podgladBmp.Height) / Convert.ToDouble(podgladPictureBox.Height);
                }
                else
                {
                    proporcje = Convert.ToDouble(podgladBmp.Width) / Convert.ToDouble(podgladPictureBox.Width);
                }
                
                pikselx = Convert.ToInt32(Convert.ToDouble(podgladBmp.Width)/proporcje);
                piksely = Convert.ToInt32(Convert.ToDouble(podgladBmp.Height) / proporcje);
                podgladBmp=algPodglad.skalujObraz(pikselx,piksely,podgladBmp);
            }

        }

        private void kontrastTrackBar_ValueChanged(object sender, EventArgs e)
        {
            Ustawienia.Kontrast = kontrastTrackBar.Value;           
            suwakBmp=algPodglad.ustawKontrast(kontrastTrackBar, (Bitmap)podgladBmp.Clone());
            tmpBmp = suwakBmp;
            suwakBmp = algPodglad.ustawJasnosc(jasnoscTrackBar, (Bitmap)tmpBmp.Clone());
            podgladPictureBox.Image = suwakBmp;
        }


        private void rozmiarObrazu()
        {
            
            Ustawienia.Wys_mm = (Convert.ToDouble(caly_obrazBmp.Height) * Ustawienia.Rozdzielczosc);
            Ustawienia.Sze_mm = (Convert.ToDouble(caly_obrazBmp.Width) * Ustawienia.Rozdzielczosc);
            wyspxTextBox.Text = caly_obrazBmp.Height.ToString();
            szpxTextBox.Text = caly_obrazBmp.Width.ToString();
            wysTextBox.Text = Math.Round(Ustawienia.Wys_mm,1).ToString();
            szeTextBox.Text = Math.Round(Ustawienia.Sze_mm, 1).ToString();
            Ustawienia.Piksel_pion = caly_obrazBmp.Height;
            Ustawienia.Piksel_poziom = caly_obrazBmp.Width;
            Ustawienia.Caly_bmp = caly_obrazBmp;
        }

        private void skalujButton_Click(object sender, EventArgs e)
        {
            Ustawienia.Piksel_pion = Convert.ToInt16(wyspxTextBox.Text);
            Ustawienia.Piksel_poziom = Convert.ToInt16(szpxTextBox.Text);
            Ustawienia.Wys_mm= Convert.ToDouble(wysTextBox.Text);
            Ustawienia.Sze_mm = Convert.ToDouble(szeTextBox.Text);
        }


    }
}
