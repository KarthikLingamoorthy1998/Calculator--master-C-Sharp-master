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
    public partial class basic : Form
    {
        public basic()
        {
            InitializeComponent();
        }

        private void basic_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int i = 1, fact = 1; ;
            for (i = 1; i <= a; i++)
            {
                fact = fact * i;
            }
            label2.Text = fact.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int k = 0, i;
            int a = int.Parse(textBox2.Text);
            for (i = 1; i <= a; i++)
            {
                if (a % i == 0)
                {
                    k++;
                }
            }
            if (k == 2)
            {
                label4.Text = "Prime Number";
            }
            else
            {
                label4.Text = "Not a prime number";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox3.Text);
            label6.Text = Math.Log(a).ToString();
        }
    }
}
