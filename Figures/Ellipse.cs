using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Ellipse: Figure
    {
<<<<<<< HEAD

        public Ellipse(string name)
        {
            base.Name = name;
        }
=======
>>>>>>> 9c865b99a3c2c30ad7ffe2aebbe1add21c92b9b1
        public override void Draw(Graphics g, Point click)
        {
            g.DrawEllipse(Pens.Black, click.X, click.Y, 60, 30);
        }
       


    }
}
