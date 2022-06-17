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
    public partial class Trignometric : Form
    {
        public Trignometric()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Trignometric_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double b = double.Parse(textBox1.Text);
            label14.Text = Math.Sin(b).ToString();
            label9.Text = Math.Cos(b).ToString();
            label10.Text = Math.Tan(b).ToString();
            label11.Text = (1 / (Math.Sin(b))).ToString();
            label12.Text=(1/(Math.Cos(b))).ToString();
            label13.Text = (1 / (Math.Tan(b))).ToString();
        }
    }
}
