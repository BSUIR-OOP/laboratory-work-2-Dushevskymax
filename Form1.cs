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

            figures.Add(new Ellipse("Ellipse"));
            figures.Add(new Rectangle("Rectangle"));
            figures.Add(new Rhombus("Rhombus"));
            figures.Add(new Segment("Segment"));
            figures.Add(new Square("Square"));
            figures.Add(new Triangle("Triangle"));
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


        private void button7_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int top = 10;
            int left = 10;
            for (int i = 0; i < figures.Count; i++)
            {
                Button button = new Button();
                button.Left = left;
                button.Top = top;
                button.Text = figures[i].Name;
                button.Tag = i;
                this.Controls.Add(button);
                top += button.Height + 4;
            }

            foreach (var item in this.Controls)
            {
                if (item is Button)
                {
                    ((Button)item).Click += CommonBtn_Click;
                }
            }
        }

        int button_index;
        private void CommonBtn_Click(object sender, EventArgs e)
        {
            button_index = Convert.ToInt16(((Button)sender).Tag);
        }
    }
}