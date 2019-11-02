using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grawer.Kontrolki
{
    class UpArrowButton : Button
    {
        protected override void OnPaint(PaintEventArgs pevent)
        {
            GraphicsPath graphics = new GraphicsPath();
            //Pen p = new Pen(Brushes.Green);
            //p.StartCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            //graphics.DrawLine(p, 120, 60, 30, 60);
            Point[] pPoints = { new Point(0, 70) , new Point(80, 70) , new Point(40, 0) };
            graphics.AddLines(pPoints);
            
            this.Region = new System.Drawing.Region(graphics);
            base.OnPaint(pevent);
        }
    }
}
