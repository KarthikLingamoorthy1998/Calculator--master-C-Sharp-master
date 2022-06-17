using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculator_16CS125
{
    public partial class BMI : Form
    {
        public BMI()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BMI_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float a = float.Parse(textBox1.Text);
            float b = float.Parse(textBox2.Text);
            float c = a / (b * b);
            if (c < 18.5)
            {
                label4.Text = "Lean";
            }
            else if (c > 18.5 && c < 25.0)
            {
                label4.Text = "Normal";
            }
            else if (c > 25.0)
            {
                label4.Text = "Obese";
            }
        }
    }
}
