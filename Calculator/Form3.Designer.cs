using System.Windows.Forms;

namespace Calculator
{
    partial class Form3
    {
        private System.ComponentModel.IContainer components = null;
        private Label label1;
        private TextBox textBoxMin;
        private TextBox textBoxMax;
        private Button buttonGenerate;
        private Label labelResult;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.label1 = new Label();
            this.textBoxMin = new TextBox();
            this.textBoxMax = new TextBox();
            this.buttonGenerate = new Button();
            this.labelResult = new Label();
            this.SuspendLayout();

            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 13);
            this.label1.Text = "Введите диапазон для генерации:";

            this.textBoxMin.Location = new System.Drawing.Point(30, 50);
            this.textBoxMin.Name = "textBoxMin";
            this.textBoxMin.Size = new System.Drawing.Size(100, 20);

            this.textBoxMax.Location = new System.Drawing.Point(150, 50);
            this.textBoxMax.Name = "textBoxMax";
            this.textBoxMax.Size = new System.Drawing.Size(100, 20);

            this.buttonGenerate.Location = new System.Drawing.Point(30, 80);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(100, 30);
            this.buttonGenerate.Text = "Сгенерировать";
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);

            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(30, 120);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 13);

            this.ClientSize = new System.Drawing.Size(300, 200);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxMin);
            this.Controls.Add(this.textBoxMax);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.labelResult);
            this.Name = "Form3";
            this.Text = "Генератор Случайного Числа";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}