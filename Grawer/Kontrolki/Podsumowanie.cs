using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using Grawer.Formy;
using System.IO;

namespace Grawer.Kontrolki
{
    public partial class Podsumowanie : UserControl
    {
        private List<Point> punkty = new List<Point>();
        private Bitmap calyBmp;
        
        Algorytmy alg = new Algorytmy();
        ArdCon arduino;
        AlgPodglad algp = new AlgPodglad();
        public Podsumowanie()
        {
            InitializeComponent();
            
        }
        public void ustawObraz()
        {
            
            calyBmp = Ustawienia.Caly_bmp;
            podgladPictureBox.Image = calyBmp;
            wczytajUstawienia();
            przygotujObraz();
            
        }
       
        public void wczytajUstawienia()
        {
            portLabel.Text = Ustawienia.PortCOM;
            wysLabel.Text = Ustawienia.Wys_mm.ToString()+"mm";
            szLabel.Text = Ustawienia.Sze_mm.ToString() + "mm";
            mocLabel.Text = Ustawienia.Moc.ToString();
            czasNaPunktLabel.Text = Ustawienia.Czas_na_punkt.ToString();
            if (Ustawienia.Wentylator1 == 0)
            {
                wenxyLabel.Text = "Włączony";
            }
            else
            {
                wenxyLabel.Text = "wyłączony";
            }
          

        }
        public void przygotujObraz()
        {
            punkty.Clear();
            //try
            //{
            //Bitmap bmap = new Bitmap(Ustawienia.Caly_bmp.Width+1, Ustawienia.Caly_bmp.Height + 1);

            calyBmp = alg.skaluj(Ustawienia.Piksel_poziom, Ustawienia.Piksel_pion, Ustawienia.Caly_bmp);

            calyBmp = alg.ustawJasnosc(Ustawienia.Jasnosc, calyBmp);
            calyBmp = alg.ustawKontrast(Ustawienia.Kontrast, calyBmp);
            Bitmap bmap = new Bitmap(calyBmp.Width + 1, calyBmp.Height + 1);
            switch (Ustawienia.Wybranyalgorytm)
                {
                    case 0:
                        podgladPictureBox.Image = null;
                        punkty.Clear();
                        punkty = alg.stucki(calyBmp, Ustawienia.Prog);
                        algorytmLabel.Text = "Stucki";
                        punktyLabel.Text = punkty.Count.ToString();
                    foreach (Point p in punkty)
                    {
                        bmap.SetPixel(p.X, p.Y, Color.Black);
                    }
                    break;
                 
                    case 1:
                        podgladPictureBox.Image = null;
                        punkty.Clear();
                        punkty = alg.floyd_Steinberg(calyBmp, Ustawienia.Prog);
                        algorytmLabel.Text = "FS";
                        punktyLabel.Text = punkty.Count.ToString();

                    foreach (Point p in punkty)
                    {
                        bmap.SetPixel(p.X, p.Y, Color.Black);
                    }
                    break;
                case 2:
                    podgladPictureBox.Image = null;
                    punkty.Clear();
                    algorytmLabel.Text = "Progowy";
                    //podgladPictureBox.Image = Ustawienia.Caly_bmp;
                    punkty = alg.progoweLista(calyBmp, Ustawienia.Prog);
                    //punktyLabel.Text = punkty.Count.ToString();
                    foreach (Point p in punkty)
                    {
                        bmap.SetPixel(p.X, p.Y, Color.Black);
                    }
                    break;
                default:
                        break;
                }
            //podgladPictureBox.Image = calyBmp;
            podgladPictureBox.Image = bmap;
                ustawCzas();
        }
        private void buttonWypal_Click(object sender, EventArgs e)
        {
            try
            {

               
                arduino.przeslij_parametry();
                Wypalanie w = new Wypalanie();
                w.ustawArduino(arduino, punkty);
                w.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Brak połączenia");
            }

        }

        
        private void przeslijUstawienia()
        {
            arduino.przeslij_parametry();
        }
       
        public void ustawArd(ArdCon ard)
        {
            arduino = ard;
        }        
        private void ustawCzas()
        {
            int suma_odleglosci = 0;
            for(int i=0;i<punkty.Count-1;i++)
            {
                suma_odleglosci += Math.Abs(punkty[i].X-punkty[i+1].X)+Math.Abs(punkty[i].Y-punkty[i+1].Y);
            }
            punktyLabel.Text = punkty.Count.ToString();
            int sekundy_pkt,minuty_pkt,godziny_pkt,sekundy_p,minuty_p,godziny_p;
            sekundy_pkt = Convert.ToInt32(((punkty.Count * Ustawienia.Czas_na_punkt) / 1000) + (suma_odleglosci * 0.012)+Ustawienia.Szybkosc*(Ustawienia.Rozdzielczosc/0.1)/1000000);
            godziny_pkt = sekundy_pkt / 3600;
           minuty_pkt = (sekundy_pkt % 3600) / 60;
           czaswypalaniaLabel.Text = godziny_pkt.ToString() + "h:" + minuty_pkt.ToString()+"m";


        }

        private void zapisDoPliku(object sender, EventArgs e)
        {
           
            gCodeDoPlikuFileDialog.InitialDirectory = @"C:\";
            gCodeDoPlikuFileDialog.RestoreDirectory = true;
            gCodeDoPlikuFileDialog.FileName = ".gcode";
            gCodeDoPlikuFileDialog.DefaultExt = ".gcode";
            if (gCodeDoPlikuFileDialog.ShowDialog() == DialogResult.OK)
            {
                Stream fileStream = gCodeDoPlikuFileDialog.OpenFile();
                StreamWriter sw = new StreamWriter(fileStream);
                sw.WriteLine("G21");
                sw.WriteLine("G90");
                sw.WriteLine("F" + Ustawienia.Szybkosc);
                if (Ustawienia.Wentylator1 == 1)
                {
                    sw.WriteLine("M106 S255");
                }
                else
                {
                    sw.WriteLine("M106 S0");
                }
                foreach (Point pkt in punkty)
                {
                    sw.WriteLine("G01 X" + pkt.X * Ustawienia.Rozdzielczosc + " Y" + pkt.Y * Ustawienia.Rozdzielczosc);
                    sw.WriteLine("M3 S" + Ustawienia.Moc);
                    sw.WriteLine("G04 P" + Ustawienia.Czas_na_punkt);
                    sw.WriteLine("M3 S0");
                }
                sw.WriteLine("M5 S0");
                sw.Close();
                fileStream.Close();
            }
            
        }
    }
}
