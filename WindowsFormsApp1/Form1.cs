using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            figures.Add(new Ellipse());
            figures.Add(new Rectangle());
            figures.Add(new Rhombus());
            figures.Add(new Segment());
            figures.Add(new Square());
            figures.Add(new Triangle());
        }

        List<Figure> figures = new List<Figure>();


        public Graphics g;
        Point click;

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g = CreateGraphics();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            click = e.Location;
            figures[button_index].Draw(g, click);
        }

        int button_index;
        private void button1_Click(object sender, EventArgs e)
        {
          button_index = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button_index = 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button_index = 2;
        }

        private void button4_Click(object sender, EventArgs e)
        {
             button_index = 3;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button_index = 4;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button_index = 5;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
        }
    }
}
