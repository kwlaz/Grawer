using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Grawer
{
    // Algorytmy dla kontrolki Podsumowanie. 
    // Przygotwouje obraz do wypalenia na podstawie ustawień użytkownika
    class Algorytmy

    {


        SerialPort port = new SerialPort();
        int[,] punkty = new int[1000000, 2];
        int prog = 100;
        private int[,] tab_bledow;
        private int kolor, prog_gora = 240, przesuniecie;
        private int dlugosc = 0, szerokosc = 0, tmp = 0, max_szerokosc = 0; //do posrtowanej tablic w celu wygenerowania.
        public Algorytmy()
        {

        }
        // Algorytm Stuckiego
        // Po zamianie znajduje czarne punktu do wypalenia
        public List<Point> stucki(Bitmap bmap, int prog)
        {
            if (prog > 239)
            {
                prog = 239;
            }
            przesuniecie = 2;
            Bitmap bmap_st = new Bitmap(bmap);
            double e = 0;
            Color p = new Color();
            Color pixelKolor;
            List<Point> punkty = new List<Point>();

            tab_bledow = new int[bmap.Width + przesuniecie + 2, bmap.Height + przesuniecie + 2];
            for (int i = 0; i < bmap.Width + przesuniecie + 2; i++)
            {
                for (int j = 0; j < bmap.Height + przesuniecie + 2; j++)
                {
                    tab_bledow[i, j] = 0;
                }
            }
            for (int y = 0; y < bmap.Height; y++)
            {

                for (int x = 0; x < bmap.Width; x++)
                {
                    pixelKolor = bmap.GetPixel(x, y);
                    kolor = (int)(pixelKolor.R * 0.229) + (int)(pixelKolor.G * 0.587) + (int)(pixelKolor.B * 0.114);
                    e = kolor + tab_bledow[x + 1, y];
                    if (prog > kolor + tab_bledow[x + 1, y])
                    {
                        bmap_st.SetPixel(x, y, Color.FromArgb(0, 0, 0));
                    }
                    else
                    {
                        if (kolor > prog_gora)
                        {
                            bmap_st.SetPixel(x, y, Color.FromArgb(255, 255, 255));
                        }
                        else
                        {
                            bmap_st.SetPixel(x, y, Color.FromArgb(255, 255, 255));
                            e = e - 255;
                        }
                    }
                    tab_bledow[x + przesuniecie + 1, y] = tab_bledow[x + przesuniecie + 1, y] + Convert.ToInt32((8 * e) / 42);
                    tab_bledow[x + przesuniecie + 2, y] = tab_bledow[x + przesuniecie + 2, y] + Convert.ToInt32((4 * e) / 42);

                    tab_bledow[x + przesuniecie - 2, y + 1] = tab_bledow[x + przesuniecie - 2, y + 1] + Convert.ToInt32((2 * e) / 42);
                    tab_bledow[x + przesuniecie - 1, y + 1] = tab_bledow[x + przesuniecie - 1, y + 1] + Convert.ToInt32((4 * e) / 42);
                    tab_bledow[x + przesuniecie, y + 1] = tab_bledow[x + przesuniecie, y + 1] + Convert.ToInt32((8 * e) / 42);
                    tab_bledow[x + przesuniecie + 1, y + 1] = tab_bledow[x + przesuniecie + 1, y + 1] + Convert.ToInt32((4 * e) / 42);
                    tab_bledow[x + przesuniecie + 2, y + 1] = tab_bledow[x + przesuniecie + 2, y + 1] + Convert.ToInt32((2 * e) / 42);

                    tab_bledow[x + przesuniecie - 2, y + 2] = tab_bledow[x + przesuniecie - 2, y + 2] + Convert.ToInt32((1 * e) / 42);
                    tab_bledow[x + przesuniecie - 1, y + 2] = tab_bledow[x + przesuniecie - 1, y + 2] + Convert.ToInt32((2 * e) / 42);
                    tab_bledow[x + przesuniecie, y + 2] = tab_bledow[x + przesuniecie, y + 2] + Convert.ToInt32((4 * e) / 42);
                    tab_bledow[x + przesuniecie + 1, y + 2] = tab_bledow[x + przesuniecie + 1, y + 2] + Convert.ToInt32((2 * e) / 42);
                    tab_bledow[x + przesuniecie + 2, y + 2] = tab_bledow[x + przesuniecie + 2, y + 2] + Convert.ToInt32((1 * e) / 42);

                }
            }

            for (int y = 0; y < bmap_st.Height; y++)
            {
                if (y % 2 == 0)
                {
                    for (int x = 0; x < bmap_st.Width; x++)
                    {
                        pixelKolor = bmap_st.GetPixel(x, y);
                        kolor = (int)(pixelKolor.R * 0.229) + (int)(pixelKolor.G * 0.587) + (int)(pixelKolor.B * 0.114);
                        if (kolor < 20)
                        {
                            punkty.Add(new Point(x,y));
                        }
                    }
                }
                else
                {
                    for (int x = bmap_st.Width - 1; x >= 0; x--)
                    {
                        pixelKolor = bmap_st.GetPixel(x, y);
                        kolor = (int)(pixelKolor.R * 0.229) + (int)(pixelKolor.G * 0.587) + (int)(pixelKolor.B * 0.114);
                        if (kolor < 20)
                        {
                            punkty.Add(new Point(x,y));
                        }
                    }
                }
            }

            return punkty;
        }
        // Algorytm Floyda-Steinberga
        // Po zamianie znajduje czarne punktu do wypalenia
        public List<Point> floyd_Steinberg(Bitmap bmap, int prog)
        {
            List<Point> punkty = new List<Point>();
            przesuniecie = 2;
            Bitmap bmap_FS = new Bitmap(bmap);
            double e = 0;
            if (prog > 239)
            {
                prog = 239;
            }
            Color p = new Color();
            Color pixelKolor;
            tab_bledow = new int[bmap.Width + przesuniecie + 2, bmap.Height + przesuniecie + 2];
            for (int i = 0; i < bmap.Width + przesuniecie; i++)
            {
                for (int j = 0; j < bmap.Height + przesuniecie; j++)
                {
                    tab_bledow[i, j] = 0;
                }
            }
            for (int y = 0; y < bmap.Height; y++)
            {
                for (int x = 0; x < bmap.Width; x++)
                {
                    pixelKolor = bmap.GetPixel(x, y);
                    kolor = (int)(pixelKolor.R * 0.229) + (int)(pixelKolor.G * 0.587) + (int)(pixelKolor.B * 0.114);
                    e = kolor + tab_bledow[x + 1, y];
                    if (prog > kolor + tab_bledow[x + 1, y])
                    {
                        bmap_FS.SetPixel(x, y, Color.FromArgb(0, 0, 0));
                    }
                    else
                    {
                        if (kolor > prog_gora)
                        {
                            bmap_FS.SetPixel(x, y, Color.FromArgb(255, 255, 255));
                        }
                        else
                        {
                            bmap_FS.SetPixel(x, y, Color.FromArgb(255, 255, 255));
                            e = e - 255;
                        }
                    }
                    tab_bledow[x + 2, y] = tab_bledow[x + 2, y] + Convert.ToInt32((7 * e) / 16);

                    tab_bledow[x, y + 1] = tab_bledow[x, y + 1] + Convert.ToInt32((3 * e) / 16);
                    tab_bledow[x + 1, y + 1] = tab_bledow[x + 1, y + 1] + Convert.ToInt32((5 * e) / 16);
                    tab_bledow[x + 2, y + 1] = tab_bledow[x + 2, y + 1] + Convert.ToInt32((1 * e) / 16);
                }
            }
            for (int y = 0; y < bmap_FS.Height; y++)
            {
                if (y % 2 == 0)
                {
                    for (int x = 0; x < bmap_FS.Width; x++)
                    {
                        pixelKolor = bmap_FS.GetPixel(x, y);
                        kolor = (int)(pixelKolor.R * 0.229) + (int)(pixelKolor.G * 0.587) + (int)(pixelKolor.B * 0.114);
                        if (kolor < 20)
                        {
                            punkty.Add(new Point(x,y));
                        }
                    }
                }
                else
                {
                    for (int x = bmap_FS.Width - 1; x >= 0; x--)
                    {
                        pixelKolor = bmap_FS.GetPixel(x, y);
                        kolor = (int)(pixelKolor.R * 0.229) + (int)(pixelKolor.G * 0.587) + (int)(pixelKolor.B * 0.114);
                        if (kolor < 20)
                        {
                            punkty.Add(new Point(x,y));
                        }
                    }
                }
            }
            return punkty;
        }

        public Bitmap szarosc(Bitmap bmap)
        {
            Color kolor;
            int kolint;

            for (int y = 0; y < bmap.Height; y++)
            {
                for (int x = 0; x < bmap.Width; x++)
                {
                    kolor = bmap.GetPixel(x, y);
                    kolint = (int)(kolor.R * 0.229) + (int)(kolor.G * 0.587) + (int)(kolor.B * 0.114);
                    bmap.SetPixel(x, y, Color.FromArgb(kolint, kolint, kolint));
                }
            }

            return bmap;
        }
        public List<Point> progoweLista(Bitmap bmap, int prog)
        {
            List<Point> pkt = new List<Point>();
            bmap = szarosc(bmap);
            Color kolor = new Color();
            for (int y = 0; y < bmap.Height; y++)
            {
                if ((y % 2) ==0)
                {
                    for (int x = 0; x < bmap.Width; x++)
                    {
                        kolor = bmap.GetPixel(x, y);
                        if ((kolor.R + kolor.G + kolor.B)/3 < prog)
                        {
                            //bmap.SetPixel(x, y, Color.Black);
                            pkt.Add(new Point(x,y));
                        }
                        else
                        {
                            //bmap.SetPixel(x, y, Color.White);
                        }
                    }
                }
                else
                {
                    for (int x = bmap.Width-1; x>=0; x--)
                    {
                        kolor = bmap.GetPixel(x, y);
                        if ((kolor.R + kolor.G + kolor.B)/3 < prog)
                        {
                            //bmap.SetPixel(x, y, Color.Black);
                            pkt.Add(new Point(x,y));
                        }
                        else
                        {
                           // bmap.SetPixel(x, y, Color.White);
                        }
                    }
                }
            }
            return pkt;
        }
        public Bitmap progowe(Bitmap bmap)
        {
            bmap = szarosc(bmap);
            Color kolor = new Color();
            for (int y = 0; y < bmap.Height; y++)
            {
                for (int x = 0; x < bmap.Width; x++)
                {
                    kolor = bmap.GetPixel(x, y);
                    if ((kolor.R + kolor.G + kolor.B) < 200)
                    {
                        bmap.SetPixel(x, y, Color.Black);
                    }
                    else
                    {
                        bmap.SetPixel(x, y, Color.White);
                    }
                }
            }
            return bmap;
        }
        public List<List<string>> sasiedniePunkty(Bitmap bmap, Label label)
        {
            string[,] tablica_wektorow;
            List<string> wektor = new List<string>();
            List<List<string>> wektory = new List<List<string>>();
            int moc = 0, vx = 0, vy = 0;
            Color kolor = new Color();
            Color vkolor = new Color();
            bmap = progowe(bmap);

            int i = 0;
            for (int y = 2; y < bmap.Height - 2; y++)
            {
                for (int x = 2; x < bmap.Width - 2; x++)
                {
                    kolor = bmap.GetPixel(x, y);
                    if ((kolor.R + kolor.G + kolor.B) < prog)
                    {

                        vx = x;
                        vy = y;
                        moc = 100;
                        vkolor = bmap.GetPixel(vx, vy);
                        while ((vkolor.R + vkolor.G + vkolor.B) < prog)
                        {
                            punkty[i, 0] = vx;
                            punkty[i, 1] = vy;
                            wektor.Add(vx.ToString() + ";" + vy.ToString());
                            szerokosc++;
                            bmap.SetPixel(vx, vy, Color.White);
                            vkolor = bmap.GetPixel(vx, vy - 1);
                            if ((vkolor.R + vkolor.G + vkolor.B) < prog)
                            {

                                vy--;
                            }
                            else
                            {
                                vkolor = bmap.GetPixel(vx + 1, vy - 1);
                                if ((vkolor.R + vkolor.G + vkolor.B) < prog)
                                {
                                    vx++;
                                    vy--;
                                }
                                else
                                {
                                    vkolor = bmap.GetPixel(vx + 1, vy);
                                    if ((vkolor.R + vkolor.G + vkolor.B) < prog)
                                    {
                                        vx++;
                                    }
                                    else
                                    {
                                        vkolor = bmap.GetPixel(vx + 1, vy + 1);
                                        if ((vkolor.R + vkolor.G + vkolor.B) < prog)
                                        {
                                            vx++;
                                            vy++;
                                        }
                                        else
                                        {
                                            vkolor = bmap.GetPixel(vx, vy + 1);
                                            if ((vkolor.R + vkolor.G + vkolor.B) < prog)
                                            {
                                                vy++;
                                            }
                                            else
                                            {
                                                vkolor = bmap.GetPixel(vx - 1, vy + 1);
                                                if ((vkolor.R + vkolor.G + vkolor.B) < prog)
                                                {
                                                    vx--;
                                                    vy++;
                                                }
                                                else
                                                {
                                                    vkolor = bmap.GetPixel(vx - 1, vy);
                                                    if ((vkolor.R + vkolor.G + vkolor.B) < prog)
                                                    {
                                                        vx--;
                                                    }
                                                    else
                                                    {
                                                        vx--;
                                                        vy--;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                            i++;

                        }
                        if (szerokosc > max_szerokosc)
                        {
                            max_szerokosc = szerokosc;
                        }
                        szerokosc = 0;
                        wektory.Add(new List<string>(wektor));
                        wektor.Clear();
                        dlugosc++;
                    }

                    bmap.SetPixel(vx, vy, Color.White);
                }
            }



            dlugosc = 0; szerokosc = 0;


            tablica_wektorow = new string[wektory.Count, 4];


            for (int id = 0; id < wektory.Count; id++)
            {

                tablica_wektorow[id, 0] = wektory[id].First();
                tablica_wektorow[id, 1] = wektory[id].Last();
                tablica_wektorow[id, 2] = id.ToString();
                tablica_wektorow[id, 3] = "n";
            }

            List<List<string>> posortowane_wektory = new List<List<string>>();
            List<string> wek = new List<string>();
            string[] tmp_wektor = new string[4];
            double min_wyn, wyn;
            int indeks = 0, tyl = 0;
            Point p1 = new Point();
            Point p2 = new Point();
            string[] pkt_string;
            posortowane_wektory.Add(wektory[0]);
            pkt_string = tablica_wektorow[0, 1].Split(';');
            p1.X = Convert.ToInt16(pkt_string[0]);
            p1.Y = Convert.ToInt16(pkt_string[1]);
            pkt_string = tablica_wektorow[1, 1].Split(';');
            p2.X = Convert.ToInt16(pkt_string[0]);
            p2.Y = Convert.ToInt16(pkt_string[1]);
            wyn = odleglosc_Pkt(p1, p2);
            min_wyn = wyn;
            indeks = 1;
            for (int k = 0; k < wektory.Count; k++)
            {
                pkt_string = tablica_wektorow[k, 1].Split(';');
                p1.X = Convert.ToInt16(pkt_string[0]);
                p1.Y = Convert.ToInt16(pkt_string[1]);
                for (int id = k + 1; id < wektory.Count - 1; id++)
                {
                    pkt_string = tablica_wektorow[id, 0].Split(';');
                    p2.X = Convert.ToInt16(pkt_string[0]);
                    p2.Y = Convert.ToInt16(pkt_string[1]);
                    wyn = odleglosc_Pkt(p1, p2);
                    if (wyn < min_wyn)
                    {
                        min_wyn = wyn;
                        tyl = 0;
                        indeks = id;

                    }

                    pkt_string = tablica_wektorow[id, 1].Split(';');
                    p2.X = Convert.ToInt16(pkt_string[0]);
                    p2.Y = Convert.ToInt16(pkt_string[1]);
                    wyn = odleglosc_Pkt(p1, p2);
                    if (wyn < min_wyn)
                    {
                        min_wyn = wyn;
                        tyl = 1;
                        indeks = id;
                    }


                }
                //zamiana
                if (tyl == 1)
                {
                    tmp_wektor[0] = tablica_wektorow[indeks, 1];
                    tmp_wektor[1] = tablica_wektorow[indeks, 0];
                    tmp_wektor[3] = "t";
                }
                else
                {
                    tmp_wektor[0] = tablica_wektorow[indeks, 0];
                    tmp_wektor[1] = tablica_wektorow[indeks, 1];
                    tmp_wektor[3] = "n";
                }
                tmp_wektor[2] = tablica_wektorow[indeks, 2];


                tablica_wektorow[indeks, 0] = tablica_wektorow[k, 0];
                tablica_wektorow[indeks, 1] = tablica_wektorow[k, 1];
                tablica_wektorow[indeks, 2] = tablica_wektorow[k, 2];
                tablica_wektorow[indeks, 3] = tablica_wektorow[k, 3];

                tablica_wektorow[k, 0] = tmp_wektor[0];
                tablica_wektorow[k, 1] = tmp_wektor[1];
                tablica_wektorow[k, 2] = tmp_wektor[2];
                tablica_wektorow[k, 3] = tmp_wektor[3];

                min_wyn = bmap.Height * bmap.Width;
                tyl = 0;
                indeks = k + 1;

            }
            List<string> pos_wek = new List<string>();
            int tmp_indeks = 0;
            foreach (List<string> pw in wektory)
            {

                if (tablica_wektorow[tmp_indeks, 3] == "n")
                {
                    for (int k = 0; k < pw.Count; k++)
                    {

                        pos_wek.Add("a;" + pw[k]);
                    }
                }
                else
                {
                    for (int k = pw.Count - 1; k > 0; k--)
                    {
                        pos_wek.Add("a;" + pw[k]);
                    }
                }
                posortowane_wektory.Add(new List<string>(pos_wek));
                tmp_indeks++;
                pos_wek.Clear();
            }
            tmp_indeks = 0;





            return posortowane_wektory;
        }

        private double odleglosc_Pkt(Point p1, Point p2)
        {
            double wynik = 0;
            wynik = Math.Sqrt(Math.Pow((p2.X - p1.X), 2) + Math.Pow((p2.Y - p1.Y), 2));
            return wynik;
        }
        public Bitmap skaluj(int piksel_poziom, int piksel_pion, Image img)
        {
            try
            {
                Rectangle rect = new Rectangle(0, 0, piksel_poziom, piksel_pion);
                Bitmap skImage = new Bitmap(piksel_poziom, piksel_pion);
                skImage.SetResolution(img.HorizontalResolution, img.VerticalResolution);
                using (var g = Graphics.FromImage(skImage))
                {
                    g.CompositingMode = CompositingMode.SourceCopy;
                    g.CompositingQuality = CompositingQuality.HighQuality;
                    g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                    g.SmoothingMode = SmoothingMode.HighQuality;
                    g.PixelOffsetMode = PixelOffsetMode.HighQuality;
                    using (var wrapmode = new ImageAttributes())
                    {
                        wrapmode.SetWrapMode(WrapMode.TileFlipXY);
                        g.DrawImage(img, rect, 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, wrapmode);
                    }
                }
                return skImage;
            }
            catch { return (Bitmap)img; }

        }
        public Bitmap ustawKontrast(int kon, Bitmap bmap)
        {

            byte[] LUT = new byte[256];
            double a;
            if (kon <= 0)
            {
                a = 1.0 + (kon / 256.0);
            }
            else
            {
                a = 256.0 / Math.Pow(2, Math.Log(257 - kon, 2));
            }

            for (int i = 0; i < 256; i++)
            {
                if ((a * (i - 127) + 127) > 255)
                {
                    LUT[i] = 255;
                }
                else if ((a * (i - 127) + 127) < 0)
                {
                    LUT[i] = 0;
                }
                else
                {
                    LUT[i] = (byte)(a * (i - 127) + 127);
                }

            }



            BitmapData bmpData = bmap.LockBits(new Rectangle(0, 0, bmap.Width, bmap.Height), ImageLockMode.ReadWrite, bmap.PixelFormat);
            byte[] pixelValues = new byte[Math.Abs(bmpData.Stride) * bmap.Height];
            System.Runtime.InteropServices.Marshal.Copy(bmpData.Scan0, pixelValues, 0, pixelValues.Length);

            for (int i = 0; i < pixelValues.Length; i++)
            {
                pixelValues[i] = LUT[pixelValues[i]];
            }

            for (int i = 0; i < pixelValues.Length; i++)
            {
                pixelValues[i] = LUT[pixelValues[i]];
            }

            System.Runtime.InteropServices.Marshal.Copy(pixelValues, 0, bmpData.Scan0, pixelValues.Length);
            bmap.UnlockBits(bmpData);
            return bmap;
        }
        public Bitmap ustawJasnosc(int jas, Bitmap bmap)
        {
            byte[] LUT = new byte[256];
            int b = jas;
            for (int i = 0; i < 256; i++)
            {
                if ((b + i) > 255)
                {
                    LUT[i] = 255;
                }
                else if ((b + i) < 0)
                {
                    LUT[i] = 0;
                }
                else
                {
                    LUT[i] = (byte)(b + i);
                }

            }



            BitmapData bmpData = bmap.LockBits(new Rectangle(0, 0, bmap.Width, bmap.Height), ImageLockMode.ReadWrite, bmap.PixelFormat);
            byte[] pixelValues = new byte[Math.Abs(bmpData.Stride) * bmap.Height];
            System.Runtime.InteropServices.Marshal.Copy(bmpData.Scan0, pixelValues, 0, pixelValues.Length);

            for (int i = 0; i < pixelValues.Length; i++)
            {
                pixelValues[i] = LUT[pixelValues[i]];
            }
            System.Runtime.InteropServices.Marshal.Copy(pixelValues, 0, bmpData.Scan0, pixelValues.Length);
            bmap.UnlockBits(bmpData);
            return bmap;
        }
        public Bitmap progowe(Bitmap bmap, int prog)
        {

            Color kolor = new Color();
            for (int y = 0; y < bmap.Height; y++)
            {
                for (int x = 0; x < bmap.Width; x++)
                {
                    kolor = bmap.GetPixel(x, y);
                    if ((kolor.R + kolor.G + kolor.B) < prog)
                    {
                        bmap.SetPixel(x, y, Color.Black);
                    }
                    else
                    {
                        bmap.SetPixel(x, y, Color.White);
                    }
                }
            }
            return bmap;
        }
    }

}

