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
            g.DrawRectangle(Pens.Black, click.X, click.Y, 80,40);
        }

    }
}
