using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            PerformOperation((a, b) => a + b);
        }

        private void buttonSubtract_Click(object sender, EventArgs e)
        {
            PerformOperation((a, b) => a - b);
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            PerformOperation((a, b) => a * b);
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            PerformOperation((a, b) =>
            {
                if (b == 0)
                {
                    MessageBox.Show("На ноль делить нельзя.");
                    return 0;
                }
                return a / b;
            });
        }

        private void buttonPower_Click(object sender, EventArgs e)
        {
            PerformOperation((a, b) => Math.Pow(a, b));
        }

        private void buttonMod_Click(object sender, EventArgs e)
        {
            PerformOperation((a, b) => a % b);
        }

        private void buttonMax_Click(object sender, EventArgs e)
        {
            PerformOperation((a, b) => Math.Max(a, b));
        }

        private void buttonMin_Click(object sender, EventArgs e)
        {
            PerformOperation((a, b) => Math.Min(a, b));
        }

        private void PerformOperation(Func<double, double, double> operation)
        {
            if (double.TryParse(textBox1.Text, out double num1) && double.TryParse(textBox2.Text, out double num2))
            {
                double result = operation(num1, num2);
                label1.Text = $"Результат: {result}";
            }
            else
            {
                MessageBox.Show("Введите правильные числа.");
            }
        }
    }
}
