using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace regression_app
{
    public partial class Form1 : Form
    {
        double a = -0.836299077762619;      // intercept
        double b1 = 0.0209264397439228;     // pregnancies
        double b2 = 0.00570910928331046;    // glucose
        double b3 = -0.00235721223666517;   // bloddPressure
        double b4 = 0.0130807321960313;     // BMI
        double b5 = 0.140301672799981;      // diabetesPedigreeFunstion
        double b6 = 0.00279171098618659;    // age

        public Form1()
        {
            InitializeComponent();
        }

        public int getOutcome(double x1, double x2, double x3, double x4, double x5, double x6)
        {
            double result = 0;

            result = (x1 * b1) + (x2 * b2) + (x3 * b3) + (x4 * b4) + (x5 * b5) + (x6 * b6);

            return Convert.ToInt32(result);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
