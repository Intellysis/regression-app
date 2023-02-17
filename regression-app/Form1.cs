using System;
using System.Windows.Forms;

namespace regression_app
{
    public partial class Form1 : Form
    {
        double a = -0.836299077762619;      // Intercept
        double b1 = 0.0209264397439228;     // Pregnancies
        double b2 = 0.00570910928331046;    // Glucose
        double b3 = -0.00235721223666517;   // Blodd Pressure
        double b4 = 0.0130807321960313;     // BMI
        double b5 = 0.140301672799981;      // Diabetes Pedigree Function
        double b6 = 0.00279171098618659;    // Age

        public Form1()
        {
            InitializeComponent();
        }

        public int GetOutcome(double x1, double x2, double x3, double x4, double x5, double x6)
        {
            double result = (x1 * b1) + (x2 * b2) + (x3 * b3) + (x4 * b4) + (x5 * b5) + (x6 * b6) + a;

            return (int)Math.Ceiling(result);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            var x1 = Convert.ToDouble(textBox1.Text);
            var x2 = Convert.ToDouble(textBox2.Text);
            var x3 = Convert.ToDouble(textBox3.Text);
            var x4 = Convert.ToDouble(textBox4.Text);
            var x5 = Convert.ToDouble(textBox5.Text);
            var x6 = Convert.ToDouble(textBox6.Text);

            var result = GetOutcome(x1, x2, x3, x4, x5, x6);

            if (result == 1)
            {
                label9.Text = "Oh no!";
                label5.Text = "You are Diabetic!";
            }
            else
            {
                label9.Text = "Yehey!";
                label5.Text = "You're not Diabetic!";
            }
        }
    }
}
