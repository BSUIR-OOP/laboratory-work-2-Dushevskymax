<<<<<<< HEAD
﻿using System.Drawing;

namespace Lab2
{
    public sealed class Rectangle : Figure
    {
        public override Point[] GetPoints(Point click)
        {
            return new Point[]
            {
                new Point(click.X - 40, click.Y - 20),
                new Point(click.X + 40, click.Y - 20),
                new Point(click.X + 40, click.Y + 20),
                new Point(click.X - 40, click.Y + 20)
            };
        }

=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Rectangle : Figure
    {
<<<<<<< HEAD

        public Rectangle(string name)
        {
            base.Name = name;
        }
=======
>>>>>>> 9c865b99a3c2c30ad7ffe2aebbe1add21c92b9b1
        public override void Draw(Graphics g, Point click)
        {
            Point[] pts = { new Point(click.X, click.Y), new Point(click.X, click.Y + 35), new Point(click.X + 50, click.Y + 35), new Point(click.X+50, click.Y) };
            g.DrawPolygon(Pens.Black, pts);
        }
>>>>>>> 0868523cadcf594bfd6123076661bd527d053edd

    }
}
