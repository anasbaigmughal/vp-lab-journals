using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lab6_Ex2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void audiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "C:/Users/MABM/Desktop/1.png";
            label5.Text = "2016"; //model
            label6.Text = "Audi"; //brand
            label7.Text = "Black"; //colour
            label8.Text = "2500cc"; //engine power
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void mercedesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "C:/Users/MABM/Desktop/2.png";
            label5.Text = "2015"; //model
            label6.Text = "Mercedes"; //brand
            label7.Text = "Black"; //colour
            label8.Text = "3000cc"; //engine power
        }

        private void toyotaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "C:/Users/MABM/Desktop/3.png";
            label5.Text = "2017"; //model
            label6.Text = "Toyota"; //brand
            label7.Text = "Red"; //colour
            label8.Text = "3000cc"; //engine power
        }

        private void hondaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "C:/Users/MABM/Desktop/4.png";
            label5.Text = "2012"; //model
            label6.Text = "Honda"; //brand
            label7.Text = "Black"; //colour
            label8.Text = "3500cc"; //engine power
        }
    }
}
