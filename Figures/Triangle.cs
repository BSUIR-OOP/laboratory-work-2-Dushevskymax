using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Triangle : Figure
    {
        public override void Draw(Graphics g, Point click)
        {
            Point[] pts = { new Point(click.X + 25, click.Y), new Point(click.X + 50, click.Y + 60), new Point(click.X, click.Y + 60) };
            g.DrawPolygon(Pens.Black, pts);
        }

    }
}
