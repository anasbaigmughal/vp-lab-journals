using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lab6_Ex3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            initialHide();
        }

        private void matrixToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox19.Text = Convert.ToString(int.Parse(textBox1.Text) + int.Parse(textBox10.Text));
            textBox20.Text = Convert.ToString(int.Parse(textBox2.Text) + int.Parse(textBox11.Text));
            textBox21.Text = Convert.ToString(int.Parse(textBox3.Text) + int.Parse(textBox12.Text));
            textBox22.Text = Convert.ToString(int.Parse(textBox4.Text) + int.Parse(textBox13.Text));
            textBox23.Text = Convert.ToString(int.Parse(textBox5.Text) + int.Parse(textBox14.Text));
            textBox24.Text = Convert.ToString(int.Parse(textBox6.Text) + int.Parse(textBox15.Text));
            textBox25.Text = Convert.ToString(int.Parse(textBox7.Text) + int.Parse(textBox16.Text));
            textBox26.Text = Convert.ToString(int.Parse(textBox8.Text) + int.Parse(textBox17.Text));
            textBox27.Text = Convert.ToString(int.Parse(textBox9.Text) + int.Parse(textBox18.Text));
        }

        private void x2MatrixToolStripMenuItem_Click(object sender, EventArgs e)
        {
            initialHide();
            textBox1.Show(); textBox2.Show(); textBox4.Show(); textBox5.Show();
            textBox10.Show(); textBox11.Show(); textBox13.Show(); textBox14.Show();
            textBox19.Show(); textBox20.Show(); textBox22.Show(); textBox23.Show();
        }

        private void x3MatrixToolStripMenuItem_Click(object sender, EventArgs e)
        {
            initialHide();
            textBox1.Show(); textBox2.Show(); textBox3.Show(); textBox4.Show(); textBox5.Show(); textBox6.Show(); textBox7.Show(); textBox8.Show(); textBox9.Show(); textBox10.Show(); textBox11.Show(); textBox12.Show(); textBox13.Show(); textBox14.Show(); textBox15.Show(); textBox16.Show(); textBox17.Show(); textBox18.Show(); textBox19.Show(); textBox20.Show(); textBox21.Show(); textBox22.Show(); textBox23.Show(); textBox24.Show(); textBox25.Show(); textBox26.Show(); textBox27.Show();
        }

        public void initialHide()
        {
            textBox1.Hide();textBox2.Hide();textBox3.Hide();textBox4.Hide();textBox5.Hide();textBox6.Hide();textBox7.Hide();textBox8.Hide();textBox9.Hide();textBox10.Hide();textBox11.Hide();textBox12.Hide();textBox13.Hide();textBox14.Hide();textBox15.Hide();textBox16.Hide();textBox17.Hide();textBox18.Hide();textBox19.Hide();textBox20.Hide();textBox21.Hide();textBox22.Hide();textBox23.Hide();textBox24.Hide();textBox25.Hide();textBox26.Hide();textBox27.Hide();
            
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox19.Text = Convert.ToString(int.Parse(textBox1.Text) - int.Parse(textBox10.Text));
            textBox20.Text = Convert.ToString(int.Parse(textBox2.Text) - int.Parse(textBox11.Text));
            textBox21.Text = Convert.ToString(int.Parse(textBox3.Text) - int.Parse(textBox12.Text));
            textBox22.Text = Convert.ToString(int.Parse(textBox4.Text) - int.Parse(textBox13.Text));
            textBox23.Text = Convert.ToString(int.Parse(textBox5.Text) - int.Parse(textBox14.Text));
            textBox24.Text = Convert.ToString(int.Parse(textBox6.Text) - int.Parse(textBox15.Text));
            textBox25.Text = Convert.ToString(int.Parse(textBox7.Text) - int.Parse(textBox16.Text));
            textBox26.Text = Convert.ToString(int.Parse(textBox8.Text) - int.Parse(textBox17.Text));
            textBox27.Text = Convert.ToString(int.Parse(textBox9.Text) - int.Parse(textBox18.Text));
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            textBox19.Text = Convert.ToString((int.Parse(textBox1.Text)*int.Parse(textBox10.Text))+(int.Parse(textBox2.Text)*int.Parse(textBox13.Text))+(int.Parse(textBox3.Text)*int.Parse(textBox16.Text)));
            textBox20.Text = Convert.ToString((int.Parse(textBox1.Text)*int.Parse(textBox11.Text))+(int.Parse(textBox2.Text)*int.Parse(textBox14.Text))+(int.Parse(textBox3.Text)*int.Parse(textBox17.Text)));
            textBox21.Text = Convert.ToString((int.Parse(textBox1.Text)*int.Parse(textBox12.Text))+(int.Parse(textBox2.Text)*int.Parse(textBox15.Text))+(int.Parse(textBox3.Text)*int.Parse(textBox18.Text)));
            textBox22.Text = Convert.ToString((int.Parse(textBox4.Text)*int.Parse(textBox10.Text))+(int.Parse(textBox5.Text)*int.Parse(textBox13.Text))+(int.Parse(textBox6.Text)*int.Parse(textBox16.Text)));
            textBox23.Text = Convert.ToString((int.Parse(textBox4.Text)*int.Parse(textBox11.Text))+(int.Parse(textBox5.Text)*int.Parse(textBox14.Text))+(int.Parse(textBox6.Text)*int.Parse(textBox17.Text)));
            textBox24.Text = Convert.ToString((int.Parse(textBox4.Text)*int.Parse(textBox12.Text))+(int.Parse(textBox5.Text)*int.Parse(textBox15.Text))+(int.Parse(textBox6.Text)*int.Parse(textBox18.Text)));
            textBox25.Text = Convert.ToString((int.Parse(textBox7.Text)*int.Parse(textBox10.Text))+(int.Parse(textBox8.Text)*int.Parse(textBox13.Text))+(int.Parse(textBox9.Text)*int.Parse(textBox16.Text)));
            textBox26.Text = Convert.ToString((int.Parse(textBox7.Text)*int.Parse(textBox11.Text))+(int.Parse(textBox8.Text)*int.Parse(textBox14.Text))+(int.Parse(textBox9.Text)*int.Parse(textBox17.Text)));
            textBox27.Text = Convert.ToString((int.Parse(textBox7.Text) * int.Parse(textBox11.Text)) + (int.Parse(textBox8.Text) * int.Parse(textBox15.Text)) + (int.Parse(textBox9.Text) * int.Parse(textBox18.Text)));
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
