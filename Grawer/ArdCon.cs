using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Klasa do nawiązania połączenia z urządzeniem oraz przesyłania danych do urządzenia
namespace Grawer
{
    public class ArdCon
    {
        private string[] porty;
        SerialPort port = new SerialPort();
        public void znajdzPorty(ComboBox comboBox)
        {
            porty = SerialPort.GetPortNames();
            comboBox.Items.AddRange(porty);
        }
        public void polacz(string nazwa)
        {
            port.BaudRate = 57600;
            port.PortName = nazwa;
            port.Open();
        }
        public void rozlacz()
        {
            port.Close();
        }
        public void przeslij_parametry(){           
            if (Ustawienia.Wentylator1 == 1)
            {
                port.WriteLine("M106"); // włącz wentylator
            }
            else
            { 
                port.WriteLine("M107"); //wyłącz wentylator
            }
            port.ReadLine();
            port.WriteLine("G21"); // wymiarowanie w mm
            port.ReadLine();
            port.WriteLine("G90"); //pozycjonowanie bezzwzględne
            port.ReadLine();
            port.WriteLine("G92"); //zeruj pozycję
            port.ReadLine();
            port.WriteLine("F" + Ustawienia.Szybkosc); // prędkość posuwu
            port.ReadLine();
        }
        public void przesun(string kom,string przesuniecie)
        {
            port.WriteLine(kom+ przesuniecie);
            port.ReadLine();
        }
        public void wyslij_komende(string komenda)
        {
            port.WriteLine(komenda);
            port.ReadLine();
     
        }
        public void wypal(Point p)
        {
            //port.WriteLine("G01 X" + p.X*Ustawienia.Rozdzielczosc+ " Y" + p.Y*Ustawienia.Rozdzielczosc+" S"+Ustawienia.Moc+ " P"+Ustawienia.Czas_na_punkt); // Ustaw głowicę w zadanej pozycji
            port.WriteLine("G01 X" + p.X * Ustawienia.Rozdzielczosc + " Y" + p.Y * Ustawienia.Rozdzielczosc);
            port.ReadLine();
            port.WriteLine("M3 S" + Ustawienia.Moc); //Włącz lasera z zadaną mocą
            port.ReadLine();
            port.WriteLine("G04 P" + Ustawienia.Czas_na_punkt); //czekaj
            port.ReadLine();
            port.WriteLine("M3 S1"); //Włącz lasera z zadaną mocą
            port.ReadLine();
        }
        public void otworzPort()
        {
           
            try
            {
                port.Open();
            }
            catch
            {

            }
        }
        public void zamknijPort()
        {
            try
            {
                port.Close();
            }
            catch
            {

            }
        }

    }
}
