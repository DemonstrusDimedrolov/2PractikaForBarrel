using System.Windows.Forms;

namespace Calculator
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button buttonAdd;
        private Button buttonSubtract;
        private Button buttonMultiply;
        private Button buttonDivide;
        private Button buttonPower;
        private Button buttonMod;
        private Button buttonMax;
        private Button buttonMin;

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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonSubtract = new System.Windows.Forms.Button();
            this.buttonMultiply = new System.Windows.Forms.Button();
            this.buttonDivide = new System.Windows.Forms.Button();
            this.buttonPower = new System.Windows.Forms.Button();
            this.buttonMod = new System.Windows.Forms.Button();
            this.buttonMax = new System.Windows.Forms.Button();
            this.buttonMin = new System.Windows.Forms.Button();
            this.SuspendLayout();

            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Результат: ";

            this.textBox1.Location = new System.Drawing.Point(50, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;

            this.textBox2.Location = new System.Drawing.Point(180, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;

            this.buttonAdd.Location = new System.Drawing.Point(50, 100);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(50, 30);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "+";
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);

            this.buttonSubtract.Location = new System.Drawing.Point(110, 100);
            this.buttonSubtract.Name = "buttonSubtract";
            this.buttonSubtract.Size = new System.Drawing.Size(50, 30);
            this.buttonSubtract.TabIndex = 4;
            this.buttonSubtract.Text = "-";
            this.buttonSubtract.Click += new System.EventHandler(this.buttonSubtract_Click);

            this.buttonMultiply.Location = new System.Drawing.Point(170, 100);
            this.buttonMultiply.Name = "buttonMultiply";
            this.buttonMultiply.Size = new System.Drawing.Size(50, 30);
            this.buttonMultiply.TabIndex = 5;
            this.buttonMultiply.Text = "*";
            this.buttonMultiply.Click += new System.EventHandler(this.buttonMultiply_Click);

            this.buttonDivide.Location = new System.Drawing.Point(230, 100);
            this.buttonDivide.Name = "buttonDivide";
            this.buttonDivide.Size = new System.Drawing.Size(50, 30);
            this.buttonDivide.TabIndex = 6;
            this.buttonDivide.Text = "/";
            this.buttonDivide.Click += new System.EventHandler(this.buttonDivide_Click);

            this.buttonPower.Location = new System.Drawing.Point(50, 140);
            this.buttonPower.Name = "buttonPower";
            this.buttonPower.Size = new System.Drawing.Size(50, 30);
            this.buttonPower.TabIndex = 7;
            this.buttonPower.Text = "^";
            this.buttonPower.Click += new System.EventHandler(this.buttonPower_Click);

            this.buttonMod.Location = new System.Drawing.Point(110, 140);
            this.buttonMod.Name = "buttonMod";
            this.buttonMod.Size = new System.Drawing.Size(50, 30);
            this.buttonMod.TabIndex = 8;
            this.buttonMod.Text = "%";
            this.buttonMod.Click += new System.EventHandler(this.buttonMod_Click);
 
            this.buttonMax.Location = new System.Drawing.Point(170, 140);
            this.buttonMax.Name = "buttonMax";
            this.buttonMax.Size = new System.Drawing.Size(50, 30);
            this.buttonMax.TabIndex = 9;
            this.buttonMax.Text = "Max";
            this.buttonMax.Click += new System.EventHandler(this.buttonMax_Click);

            this.buttonMin.Location = new System.Drawing.Point(230, 140);
            this.buttonMin.Name = "buttonMin";
            this.buttonMin.Size = new System.Drawing.Size(50, 30);
            this.buttonMin.TabIndex = 10;
            this.buttonMin.Text = "Min";
            this.buttonMin.Click += new System.EventHandler(this.buttonMin_Click);

            this.ClientSize = new System.Drawing.Size(334, 211);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonSubtract);
            this.Controls.Add(this.buttonMultiply);
            this.Controls.Add(this.buttonDivide);
            this.Controls.Add(this.buttonPower);
            this.Controls.Add(this.buttonMod);
            this.Controls.Add(this.buttonMax);
            this.Controls.Add(this.buttonMin);
            this.Name = "Form1";
            this.Text = "Простой Калькулятор";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
