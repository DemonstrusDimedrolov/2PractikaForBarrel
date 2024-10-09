using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form3 : Form
    {
        private Random random;

        public Form3()
        {
            InitializeComponent();
            random = new Random();
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            int minValue;
            int maxValue;

            if (int.TryParse(textBoxMin.Text, out minValue) && int.TryParse(textBoxMax.Text, out maxValue))
            {
                if (minValue < maxValue)
                {
                    int randomNumber = random.Next(minValue, maxValue + 1);
                    labelResult.Text = $"Случайное число: {randomNumber}";
                }
                else
                {
                    MessageBox.Show("Минимальное значение должно быть меньше максимального.");
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите корректные целые числа.");
            }
        }
    }
}