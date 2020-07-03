using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace vplab12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics obj = this.CreateGraphics();
            Point p1 = new Point(10, 10);
            Point p2 = new Point(50, 50);
            Pen p = new Pen(Color.Black, 8);
            obj.DrawLine(p, p1, p2);
            Rectangle rect = new Rectangle();
            obj.DrawRectangle(p, rect);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Graphics obj = this.CreateGraphics();
            if (comboBox1.SelectedIndex == 0)
            {
                this.Refresh();
                Point p1 = new Point(10, 10);
                Point p2 = new Point(50, 50);
                Pen p = new Pen(Color.Black, 4);
                Rectangle rect = new Rectangle(150, 100, 100, 100);
                obj.DrawEllipse(p, rect);
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                this.Refresh();
                Point p1 = new Point(10, 10);
                Point p2 = new Point(50, 50);
                Pen p = new Pen(Color.Black, 4);

                Rectangle rect = new Rectangle(150, 100, 100, 70);
                obj.DrawEllipse(p, rect);
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                this.Refresh();
                Point p1 = new Point(10, 10);
                Point p2 = new Point(50, 50);
                Pen p = new Pen(Color.Black, 4);

                Rectangle rect = new Rectangle(150, 100, 100, 70);
                obj.DrawRectangle(p, rect);
            }
        }
    }
}
