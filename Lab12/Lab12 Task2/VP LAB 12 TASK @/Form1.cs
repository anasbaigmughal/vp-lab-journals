using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VP_LAB_12_TASK__
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics obj = this.CreateGraphics();

            Rectangle rect1 = new Rectangle(150, 100, 100, 100);
            Pen p1 = new Pen(Color.Blue, 4);
            obj.DrawEllipse(p1, rect1);
            Rectangle rect2 = new Rectangle(270, 100, 100, 100);
            Pen p2 = new Pen(Color.Black, 4);
            obj.DrawEllipse(p2, rect2);
            Rectangle rect3 = new Rectangle(390, 100, 100, 100);
            Pen p3 = new Pen(Color.Red, 4);
            obj.DrawEllipse(p3, rect3);
            Rectangle rect4 = new Rectangle(210, 150, 100, 100);
            Pen p4 = new Pen(Color.Yellow, 4);
            obj.DrawEllipse(p4, rect4);
            Rectangle rect5 = new Rectangle(330, 150, 100, 100);
            Pen p5 = new Pen(Color.Green, 4);
            obj.DrawEllipse(p5, rect5);
        }
    }
}
