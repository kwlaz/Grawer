using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grawer
{
    //Klasa do przechowywania ustawień użytkownika
    class Ustawienia
    {
        private static int piksel_poziom=100;
        private static int procent_poziom=100;
        private static int procent_pion=100;
        private static int piksel_pion=100;
        private static int skala_status = 0;
        private static int szybkosc;
        private static int moc;
        private static int wentylator1;
        private static int wentylator2;
        private static double rozdzielczosc=0.2;
        private static  int kontrast=0;
        private static int jasnosc=0;
        private static int czas_na_punkt = 10;
        private static double wys_mm=0;
        private static double sze_mm = 0;
        private static int wybranyalgorytm = 0;
        private static Bitmap caly_bmp;
        private static int prog=127;
        private static string portCOM="COM";

        public static int Procent_poziom { get => procent_poziom; set => procent_poziom = value; }
        public static int Procent_pion { get => procent_pion; set => procent_pion = value; }
        public static int Piksel_pion { get => piksel_pion; set => piksel_pion = value; }
        public static int Piksel_poziom { get => piksel_poziom; set => piksel_poziom = value; }
        public static int Skala_status { get => skala_status; set => skala_status = value; }
        public static int Szybkosc { get => szybkosc; set => szybkosc = value; }
        public static int Wentylator1 { get => wentylator1; set => wentylator1 = value; }
        public static int Moc { get => moc; set => moc = value; }
        public static int Wentylator2 { get => wentylator2; set => wentylator2 = value; }
        public static double Rozdzielczosc { get => rozdzielczosc; set => rozdzielczosc = value; }
        public static int Kontrast { get => kontrast; set => kontrast = value; }
        public static int Jasnosc { get => jasnosc; set => jasnosc = value; }
        public static int Wybranyalgorytm { get => wybranyalgorytm; set => wybranyalgorytm = value; }
        public static Bitmap Caly_bmp { get => caly_bmp; set => caly_bmp = value; }
        public static int Prog { get => prog; set => prog = value; }
        public static string PortCOM { get => portCOM; set => portCOM = value; }
        public static double Wys_mm { get => wys_mm; set => wys_mm = value; }
        public static double Sze_mm { get => sze_mm; set => sze_mm = value; }
        public static int Czas_na_punkt { get => czas_na_punkt; set => czas_na_punkt = value; }
    }
}
