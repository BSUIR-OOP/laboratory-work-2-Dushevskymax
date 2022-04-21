using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Segment : Figure
    {
        public override void Draw(Graphics g, Point click)
        {
            g.DrawLine(Pens.Black, click.X, click.Y, click.X+80, click.Y-80);
        }

    }
}
