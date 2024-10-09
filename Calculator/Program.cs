using System;
using System.Windows.Forms;

namespace Calculator
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Form1 form1 = new Form1();
            Form2 form2 = new Form2();
            Form3 form3 = new Form3();

            form1.Show();
            form2.Show();
            form3.Show();

            Application.Run(); // Запускаем приложение
        }
    }
}
