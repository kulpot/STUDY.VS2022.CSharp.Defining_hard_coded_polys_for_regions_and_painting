using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Defining_hard_coded_polys_for_regions_and_painting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            //DrawDiamond(e.Graphics, this.ClientRectangle);
            DrawArrow(e.Graphics, this.ClientRectangle);
        }

        private static void DrawDiamond(Graphics graphics, Rectangle rect)
        {
            Point[] points = new Point[]
            {
                new Point(rect.Width / 2, 0),       // Upper-middle
                new Point(rect.Width, rect.Height / 2),
                new Point(rect.Width / 2, rect.Height), // Lower-middle
                new Point(0, rect.Height / 2)
            };

            graphics.FillPolygon(Brushes.Red, points);
        }

        private static void DrawArrow(Graphics graphics, Rectangle rect)
        {
            PointF[] points = new PointF[]
            {
                new PointF(rect.X + rect.Width * .5f, rect.Y),
                new PointF(rect.X + rect.Width, rect.Y + rect.Height *  .4f),
                new PointF(rect.X + rect.Width *  .7f, rect.Y + rect.Height *  .4f),
                new PointF(rect.X + rect.Width *  .7f, rect.Y + rect.Height),
                new PointF(rect.X + rect.Width *  .3f, rect.Y + rect.Height),
                new PointF(rect.X + rect.Width *  .3f, rect.Y + rect.Height *  .4f),
                new PointF(rect.X, rect.Y + rect.Height *  .4f)
            };

            graphics.FillPolygon(Brushes.Red, points);
        }
    }
}
