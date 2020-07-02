using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lab6_Ex1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bahriaUniversityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Blue;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Black;
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Red;
        }
    }
}
