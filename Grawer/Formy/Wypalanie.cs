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
    public partial class Wypalanie : Form
    {
        private int sekundy = 0;
        TimeSpan t;
        private int procent = 0;
        private List<Point> punkty;
        int ile_punktow=0;
        ArdCon arduino;
        int wprogres = 0;
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
        public Wypalanie()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }
        private void wypal()
        {
            
        }
        public void ustawArduino(ArdCon ard,List<Point> pkt)
        {
            arduino = ard;
            punkty = pkt;
            progressBar1.Maximum = punkty.Count;
            punktyLabel.Text = punkty.Count.ToString();
            
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            sekundy++;
            t = TimeSpan.FromSeconds(sekundy);

            string answer = string.Format("{0:D2}h:{1:D2}m:{2:D2}s",
                            t.Hours,
                            t.Minutes,
                            t.Seconds);
            czasLabel.Text = answer;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            arduino.otworzPort();
            arduino.wyslij_komende("");

            procent = 0;
            sekundy = 0;
            timer1.Enabled = true;
            backgroundWorker1.WorkerSupportsCancellation = true;
            backgroundWorker1.RunWorkerAsync();
           
        }

        private void anulujButton_Click(object sender, EventArgs e)
        {
            
            backgroundWorker1.CancelAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            arduino.otworzPort();
            foreach (Point p in punkty)
            {
                
                if (backgroundWorker1.CancellationPending == true)
                     {
                    e.Cancel = true;
                    return;
                    }
               
                    
                
                arduino.wypal(p);                
                backgroundWorker1.ReportProgress(0);
            }
            arduino.wyslij_komende("G90 X0 Y0");
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            wprogres++;
            ile_punktow++;
            progressBar1.Value = wprogres;
            procent = (wprogres*100) / punkty.Count();
            procentLabel.Text = procent.ToString() + "%";
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            timer1.Stop();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void gornypanel_MouseUp(object sender, MouseEventArgs e)
        {
            przesuniecie = 0;
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Cornsilk;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Black;
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
