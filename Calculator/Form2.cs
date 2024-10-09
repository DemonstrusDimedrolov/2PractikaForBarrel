using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            double temperature;

            if (double.TryParse(textBoxTemperature.Text, out temperature))
            {
                if (comboBoxConversion.SelectedIndex == 0)
                {
                    double fahrenheit = CelsiusToFahrenheit(temperature);
                    labelResult.Text = $"{fahrenheit:F2} °F";
                }
                else
                {
                    double celsius = FahrenheitToCelsius(temperature);
                    labelResult.Text = $"{celsius:F2} °C";
                }
            }
            else
            {
                MessageBox.Show("Вы ввели не правильные значения температур");
            }
        }

        private double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        private double FahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }
    }
}