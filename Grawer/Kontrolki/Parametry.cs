using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Grawer.Formy;

namespace Grawer.Kontrolki
{
    public partial class Parametry : UserControl
    {
        ArdCon arduino;
        List<List<string>> profile = new List<List<string>>();
        List<string> profil = new List<string>();
        string path = @"..\..\Profil\Profile.txt";

        public Parametry()
        {
            InitializeComponent();
            wczytajProfile();
        }
        
        private void zatwierdzButton_Click(object sender, EventArgs e)
        {
            int indeks = profileComboBox.SelectedIndex;
            List<string> aktualizacja = new List<string>();
            aktualizacja.Add(profileComboBox.Text);
            aktualizacja.Add(mocTextBox.Text);
            aktualizacja.Add(predkoscTextBox.Text);
            aktualizacja.Add(czasNaPunktTextBox.Text);            
            aktualizacja.Add(wentylatorXYComboBox.SelectedIndex.ToString());
            Ustawienia.Moc = Convert.ToInt16(aktualizacja[1]);
            Ustawienia.Szybkosc = Convert.ToInt16(aktualizacja[2]);
            Ustawienia.Czas_na_punkt = Convert.ToInt16(aktualizacja[3]);
            Ustawienia.Wentylator1 = Convert.ToInt16(aktualizacja[4]);   
            profile[indeks] = aktualizacja;
            string plik = "";
            foreach(List<string> l in profile)
            {
                foreach(string parametr in l)
                {
                    plik += parametr + ";";
                }
                plik = plik.Remove(plik.Length - 1);
                plik += "\n";
            }
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.Write(plik);

            }

        }

        private void mocTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void Parametry_Load(object sender, EventArgs e)
        {
            wentylatorXYComboBox.SelectedIndex = 0;
        }

        private void wczytajProfile()
        {
            profile.Clear();
            profileComboBox.Items.Clear();
            string odczyt;
            using (StreamReader sr = File.OpenText(path))
            {
                while ((odczyt = sr.ReadLine()) != null)
                {
                    string[] p = odczyt.Split(';');
                    profile.Add(new List<string>(p));             
                }
            }
            foreach (List<string> lp in profile)
            {
                profileComboBox.Items.Add(lp[0]);
            }            
            profileComboBox.SelectedIndex = 0;
            mocTextBox.Text = profile[0][1];
            predkoscTextBox.Text = profile[0][2];
            czasNaPunktTextBox.Text=profile[0][3];
            wentylatorXYComboBox.SelectedIndex = Convert.ToInt16(profile[0][4]);
            Ustawienia.Moc = Convert.ToInt16(profile[0][1]);
            Ustawienia.Szybkosc = Convert.ToInt16(profile[0][2]);
            Ustawienia.Czas_na_punkt= Convert.ToInt16(profile[0][3]);
            Ustawienia.Wentylator1 = Convert.ToInt16(profile[0][4]);
        }       

        private void profileComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indeks=profileComboBox.SelectedIndex;
            mocTextBox.Text = profile[indeks][1];
            predkoscTextBox.Text = profile[indeks][2];
            czasNaPunktTextBox.Text = profile[indeks][3];
            wentylatorXYComboBox.SelectedIndex = Convert.ToInt16(profile[indeks][4]);
          
            Ustawienia.Moc = Convert.ToInt16(profile[indeks][1]);
            Ustawienia.Szybkosc = Convert.ToInt16(profile[indeks][2]);
            Ustawienia.Czas_na_punkt= Convert.ToInt16(profile[indeks][3]);
            Ustawienia.Wentylator1 = Convert.ToInt16(profile[indeks][4]);
      
        }

        private void dodajProfilButton_Click(object sender, EventArgs e)
        {
            List<string> nowy_profil = new List<string>();
            NazwaProfilu np = new NazwaProfilu();
            if (np.ShowDialog()==DialogResult.OK)
            {
                profileComboBox.Items.Add(np.Nazwa);
                nowy_profil.Add(np.Nazwa);
                nowy_profil.Add(mocTextBox.Text);
                nowy_profil.Add(predkoscTextBox.Text);
                nowy_profil.Add(czasNaPunktTextBox.Text);
                nowy_profil.Add(wentylatorXYComboBox.SelectedIndex.ToString());
                profile.Add(new List<string>(nowy_profil));
                using (StreamWriter sw = new StreamWriter(path))
                {
                    string linia = "";
                    foreach(List<string> pl in profile)
                    {
                        foreach(string s in pl)
                        {
                            linia += s + ";";
                        }
                        linia = linia.Remove(linia.Length - 1);
                        sw.WriteLine(linia);
                        linia = "";
                    }
                    
                }
                profileComboBox.SelectedIndex = profileComboBox.Items.Count-1;
            }

        }
        private void podstawParametr(int ind)
        {

        }

        private void usunButton_Click(object sender, EventArgs e)
        {
            profile.RemoveAt(profileComboBox.SelectedIndex);//profileComboBox.SelectedIndex
            using (StreamWriter sw = new StreamWriter(path))
            {
                string linia = "";
                foreach (List<string> pl in profile)
                {
                    foreach (string s in pl)
                    {
                        linia += s + ";";
                    }
                    linia = linia.Remove(linia.Length - 1);
                    sw.WriteLine(linia);
                    linia = "";
                }

            }
            wczytajProfile();
        }
    }
}
