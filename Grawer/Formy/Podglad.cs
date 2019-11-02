using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grawer.Formy
{
    public partial class Podglad : Form
    {
        int przesuniecie, myszX, myszY;
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

        public Podglad()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }
        public void ustawObraz(Bitmap bmp)
        {
            pPictureBox.Image = bmp;
        }
        private void gornypanel_MouseUp(object sender, MouseEventArgs e)
        {
            przesuniecie = 0;
        }

        private void gornypanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (przesuniecie == 1)
            {
                this.SetDesktopLocation(MousePosition.X - myszX, MousePosition.Y - myszY);
            }
        }
        private void gornypanel_MouseDown(object sender, MouseEventArgs e)
        {
            przesuniecie = 1;
            myszX = e.X;
            myszY = e.Y;
        }
    }
}
