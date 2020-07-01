using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text= "0.00";
            comboBox1.Text = null;
            comboBox2.Text = null;
            comboBox3.Text = null;
            comboBox4.Text = null;
            comboBox5.Text = null;
            comboBox6.Text = null;
            comboBox7.Text = null;
            numericUpDown1.Value = 3;
            numericUpDown2.Value = 3;
            numericUpDown3.Value = 3;
            numericUpDown4.Value = 3;
            numericUpDown5.Value = 3;
            numericUpDown6.Value = 3;
            numericUpDown7.Value = 3;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            decimal totalGradePoints = 0;
            decimal obtainedGradePoints = 0;

            switch(comboBox1.Text)
            {
                case "A":
                    {
                        decimal value = numericUpDown1.Value;
                        obtainedGradePoints += (value * 4);
                        totalGradePoints += (value * 4);
                        break;
                    }
                case "B+":
                    {
                        decimal value = numericUpDown1.Value;
                        obtainedGradePoints += (value * (decimal)3.5);
                        totalGradePoints += (value * 4);
                        break;
                    }
                case " B":
                    {
                        decimal value = numericUpDown1.Value;
                        obtainedGradePoints += (value * 3);
                        totalGradePoints += (value * 4);
                        break;
                    }
                case "C+":
                    {
                        decimal value = numericUpDown1.Value;
                        obtainedGradePoints += (value * (decimal)2.5);
                        totalGradePoints += (value * 4);
                        break;
                    }
                case "C":
                    {
                        decimal value = numericUpDown1.Value;
                        obtainedGradePoints += (value * (decimal)2.5);
                        totalGradePoints += (value * 4);
                        break;
                    }
                case "D":
                    {
                        decimal value = numericUpDown1.Value;
                        obtainedGradePoints += (value * 2);
                        totalGradePoints += (value * 4);
                        break;
                    }
                    case "F":
                    {
                        decimal value = numericUpDown1.Value;
                        obtainedGradePoints += (value * 0);
                        totalGradePoints += (value * 4);
                        break;
                    }
            }
            switch (comboBox2.Text)
            {
                case "A":
                    {
                        decimal value = numericUpDown2.Value;
                        obtainedGradePoints += (value * 4);
                        totalGradePoints += (value * 4);
                        break;
                    }
                case "B+":
                    {
                        decimal value = numericUpDown2.Value;
                        obtainedGradePoints += (value * (decimal)3.5);
                        totalGradePoints += (value * 4);
                        break;
                    }
                case " B":
                    {
                        decimal value = numericUpDown2.Value;
                        obtainedGradePoints += (value * 3);
                        totalGradePoints += (value * 4);
                        break;
                    }
                case "C+":
                    {
                        decimal value = numericUpDown2.Value;
                        obtainedGradePoints += (value * (decimal)2.5);
                        totalGradePoints += (value * 4);
                        break;
                    }
                case "C":
                    {
                        decimal value = numericUpDown2.Value;
                        obtainedGradePoints += (value * (decimal)2.5);
                        totalGradePoints += (value * 4);
                        break;
                    }
                case "D":
                    {
                        decimal value = numericUpDown2.Value;
                        obtainedGradePoints += (value * 2);
                        totalGradePoints += (value * 4);
                        break;
                    }
                case "F":
                    {
                        decimal value = numericUpDown2.Value;
                        obtainedGradePoints += (value * 0);
                        totalGradePoints += (value * 4);
                        break;
                    }
            }
            switch (comboBox3.Text)
            {
                case "A":
                    {
                        decimal value = numericUpDown3.Value;
                        obtainedGradePoints += (value * 4);
                        totalGradePoints += (value * 4);
                        break;
                    }
                case "B+":
                    {
                        decimal value = numericUpDown3.Value;
                        obtainedGradePoints += (value * (decimal)3.5);
                        totalGradePoints += (value * 4);
                        break;
                    }
                case " B":
                    {
                        decimal value = numericUpDown3.Value;
                        obtainedGradePoints += (value * 3);
                        totalGradePoints += (value * 4);
                        break;
                    }
                case "C+":
                    {
                        decimal value = numericUpDown3.Value;
                        obtainedGradePoints += (value * (decimal)2.5);
                        totalGradePoints += (value * 4);
                        break;
                    }
                case "C":
                    {
                        decimal value = numericUpDown3.Value;
                        obtainedGradePoints += (value * (decimal)2.5);
                        totalGradePoints += (value * 4);
                        break;
                    }
                case "D":
                    {
                        decimal value = numericUpDown3.Value;
                        obtainedGradePoints += (value * 2);
                        totalGradePoints += (value * 4);
                        break;
                    }
                case "F":
                    {
                        decimal value = numericUpDown3.Value;
                        obtainedGradePoints += (value * 0);
                        totalGradePoints += (value * 4);
                        break;
                    }
            }
            switch (comboBox4.Text)
            {
                case "A":
                    {
                        decimal value = numericUpDown4.Value;
                        obtainedGradePoints += (value * 4);
                        totalGradePoints += (value * 4);
                        break;
                    }
                case "B+":
                    {
                        decimal value = numericUpDown4.Value;
                        obtainedGradePoints += (value * (decimal)3.5);
                        totalGradePoints += (value * 4);
                        break;
                    }
                case " B":
                    {
                        decimal value = numericUpDown4.Value;
                        obtainedGradePoints += (value * 3);
                        totalGradePoints += (value * 4);
                        break;
                    }
                case "C+":
                    {
                        decimal value = numericUpDown4.Value;
                        obtainedGradePoints += (value * (decimal)2.5);
                        totalGradePoints += (value * 4);
                        break;
                    }
                case "C":
                    {
                        decimal value = numericUpDown4.Value;
                        obtainedGradePoints += (value * (decimal)2.5);
                        totalGradePoints += (value * 4);
                        break;
                    }
                case "D":
                    {
                        decimal value = numericUpDown4.Value;
                        obtainedGradePoints += (value * 2);
                        totalGradePoints += (value * 4);
                        break;
                    }
                case "F":
                    {
                        decimal value = numericUpDown4.Value;
                        obtainedGradePoints += (value * 0);
                        totalGradePoints += (value * 4);
                        break;
                    }
            }
            switch (comboBox5.Text)
            {
                case "A":
                    {
                        decimal value = numericUpDown5.Value;
                        obtainedGradePoints += (value * 4);
                        totalGradePoints += (value * 4);
                        break;
                    }
                case "B+":
                    {
                        decimal value = numericUpDown5.Value;
                        obtainedGradePoints += (value * (decimal)3.5);
                        totalGradePoints += (value * 4);
                        break;
                    }
                case " B":
                    {
                        decimal value = numericUpDown5.Value;
                        obtainedGradePoints += (value * 3);
                        totalGradePoints += (value * 4);
                        break;
                    }
                case "C+":
                    {
                        decimal value = numericUpDown5.Value;
                        obtainedGradePoints += (value * (decimal)2.5);
                        totalGradePoints += (value * 4);
                        break;
                    }
                case "C":
                    {
                        decimal value = numericUpDown5.Value;
                        obtainedGradePoints += (value * (decimal)2.5);
                        totalGradePoints += (value * 4);
                        break;
                    }
                case "D":
                    {
                        decimal value = numericUpDown5.Value;
                        obtainedGradePoints += (value * 2);
                        totalGradePoints += (value * 4);
                        break;
                    }
                case "F":
                    {
                        decimal value = numericUpDown5.Value;
                        obtainedGradePoints += (value * 0);
                        totalGradePoints += (value * 4);
                        break;
                    }
            }
            switch (comboBox6.Text)
            {
                case "A":
                    {
                        decimal value = numericUpDown6.Value;
                        obtainedGradePoints += (value * 4);
                        totalGradePoints += (value * 4);
                        break;
                    }
                case "B+":
                    {
                        decimal value = numericUpDown6.Value;
                        obtainedGradePoints += (value * (decimal)3.5);
                        totalGradePoints += (value * 4);
                        break;
                    }
                case " B":
                    {
                        decimal value = numericUpDown6.Value;
                        obtainedGradePoints += (value * 3);
                        totalGradePoints += (value * 4);
                        break;
                    }
                case "C+":
                    {
                        decimal value = numericUpDown6.Value;
                        obtainedGradePoints += (value * (decimal)2.5);
                        totalGradePoints += (value * 4);
                        break;
                    }
                case "C":
                    {
                        decimal value = numericUpDown6.Value;
                        obtainedGradePoints += (value * (decimal)2.5);
                        totalGradePoints += (value * 4);
                        break;
                    }
                case "D":
                    {
                        decimal value = numericUpDown6.Value;
                        obtainedGradePoints += (value * 2);
                        totalGradePoints += (value * 4);
                        break;
                    }
                case "F":
                    {
                        decimal value = numericUpDown6.Value;
                        obtainedGradePoints += (value * 0);
                        totalGradePoints += (value * 4);
                        break;
                    }
            }
            switch (comboBox7.Text)
            {
                case "A":
                    {
                        decimal value = numericUpDown7.Value;
                        obtainedGradePoints += (value * 4);
                        totalGradePoints += (value * 4);
                        break;
                    }
                case "B+":
                    {
                        decimal value = numericUpDown7.Value;
                        obtainedGradePoints += (value * (decimal)3.5);
                        totalGradePoints += (value * 4);
                        break;
                    }
                case " B":
                    {
                        decimal value = numericUpDown7.Value;
                        obtainedGradePoints += (value * 3);
                        totalGradePoints += (value * 4);
                        break;
                    }
                case "C+":
                    {
                        decimal value = numericUpDown7.Value;
                        obtainedGradePoints += (value * (decimal)2.5);
                        totalGradePoints += (value * 4);
                        break;
                    }
                case "C":
                    {
                        decimal value = numericUpDown7.Value;
                        obtainedGradePoints += (value * (decimal)2.5);
                        totalGradePoints += (value * 4);
                        break;
                    }
                case "D":
                    {
                        decimal value = numericUpDown7.Value;
                        obtainedGradePoints += (value * 2);
                        totalGradePoints += (value * 4);
                        break;
                    }
                case "F":
                    {
                        decimal value = numericUpDown7.Value;
                        obtainedGradePoints += (value * 0);
                        totalGradePoints += (value * 4);
                        break;
                    }
            }
            float gpa; 
            gpa  = (float)((obtainedGradePoints/totalGradePoints)*4);
            label2.Text = Convert.ToString(gpa);
        }
    }
}
