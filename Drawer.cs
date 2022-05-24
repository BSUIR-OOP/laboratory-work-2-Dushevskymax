using System.Drawing;

namespace Lab2
{
    public static class Drawer
    {
        public static void Draw(Graphics g, Point[] points)
        {
            g.DrawPolygon(new Pen(Color.Black), points);
        }
    }
}
