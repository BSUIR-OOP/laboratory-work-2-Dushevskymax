using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Rectangle : Figure
    {
        public override void Draw(Graphics g, Point click)
        {
            Point[] pts = { new Point(click.X, click.Y), new Point(click.X, click.Y + 35), new Point(click.X + 50, click.Y + 35), new Point(click.X+50, click.Y) };
            g.DrawPolygon(Pens.Black, pts);
        }

    }
}
