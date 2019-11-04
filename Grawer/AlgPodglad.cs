using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grawer
{
    // Klasa dla kontrolki Obraz. Zawiera algorytmy do skalowania, jasności, kontrastu oraz algorytmy, które zamieniają obraz kolorowy na obraz dwubitowy.
    class AlgPodglad
    {
        private int[,] tab_bledow;
        private int kolor, prog_gora = 240, przesuniecie;
        public AlgPodglad()
        {

        }
        // Algorytm stuckiego.
        // Zamienia obraz kolorowy na dwukolorową. 
        public Bitmap stucki(Bitmap bmap,int prog)
        {
            przesuniecie = 2;
            Bitmap bmap_st = new Bitmap(bmap);
            double e = 0;
            Color p = new Color();
            Color pixelKolor;
            if (prog > 239)
            {
                prog = 239;
            }
            List<string> punkty = new List<string>();

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
                    //kolor = (int)(pixelKolor.R * 0.229) + (int)(pixelKolor.G * 0.587) + (int)(pixelKolor.B * 0.114);
                    kolor = ((int)(pixelKolor.R) + (int)(pixelKolor.G) + (int)(pixelKolor.B))/3;
                    e = kolor + tab_bledow[x + 1, y];
                    
                        if (prog > kolor + tab_bledow[x + 1, y])
                        {
                            bmap_st.SetPixel(x, y, Color.FromArgb(0, 0, 0));
                        }
                        else
                        {
                            if (prog > prog_gora)
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
            

            return bmap_st;
        }
        // Algorytm Floyda-Steinberga.
        // Zamienia obraz kolorowy na dwukolorową. 
        public Bitmap floyd_Steinberg(Bitmap bmap,int prog)
        {
            List<string> punkty = new List<string>();
            przesuniecie = 2;
            if (prog > 239)
            {
                prog = 239;
            }
            Bitmap bmap_FS = new Bitmap(bmap);
            double e = 0;
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
                    kolor = ((int)(pixelKolor.R) + (int)(pixelKolor.G) + (int)(pixelKolor.B)) / 3;
                    e = kolor + tab_bledow[x + 1, y];
                    if (prog > kolor + tab_bledow[x + 1, y])
                    {
                        bmap_FS.SetPixel(x, y, Color.FromArgb(0, 0, 0));
                    }
                    else
                    {
                        if (prog > prog_gora)
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
            return bmap_FS;
        }


        public Bitmap skalujObraz(int piksel_poziom, int piksel_pion, Image img)
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

        public Image obrocObraz(Image img, float kat)
        {
            var bmp = new Bitmap(img);

            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.White);
                g.DrawImage(img, 0, 0, img.Width, img.Height);
            }
            if (kat == 1)
            {
                bmp.RotateFlip(RotateFlipType.Rotate270FlipNone);
            }
            else
            {
                bmp.RotateFlip(RotateFlipType.Rotate90FlipNone);
            }
            return bmp;

        }

        public Bitmap ustawKontrast(TrackBar suwak,Bitmap bmap)
        {

            byte[] LUT = new byte[256];
            double a;
            if (suwak.Value <= 0)
            {
                a = 1.0 + (suwak.Value / 256.0);
            }
            else
            {
                a = 256.0 / Math.Pow(2, Math.Log(257 - suwak.Value, 2));
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
        public Bitmap ustawJasnosc(TrackBar suwak, Bitmap bmap)
        {
            byte[] LUT = new byte[256];
            int b = suwak.Value;
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
                    LUT[i] =(byte)(b + i);
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
        public Bitmap progowe(Bitmap bmap,int prog)
        {
            
            Color kolor = new Color();
            for (int y = 0; y < bmap.Height; y++)
            {
                for (int x = 0; x < bmap.Width; x++)
                {
                    kolor = bmap.GetPixel(x, y);
                    if ((kolor.R + kolor.G + kolor.B)/3 < prog)
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


    }
    }



