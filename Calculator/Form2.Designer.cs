using System.Windows.Forms;

namespace Calculator
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;
        private Label label1;
        private TextBox textBoxTemperature;
        private ComboBox comboBoxConversion;
        private Button buttonConvert;
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTemperature = new System.Windows.Forms.TextBox();
            this.comboBoxConversion = new System.Windows.Forms.ComboBox();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.SuspendLayout();

            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите температуру:";

            this.textBoxTemperature.Location = new System.Drawing.Point(30, 50);
            this.textBoxTemperature.Name = "textBoxTemperature";
            this.textBoxTemperature.Size = new System.Drawing.Size(100, 20);
            this.textBoxTemperature.TabIndex = 1;

            this.comboBoxConversion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxConversion.Items.AddRange(new object[] {
            "Цельсий в Фаренгейт",
            "Фаренгейт в Цельсий"});
            this.comboBoxConversion.Location = new System.Drawing.Point(30, 80);
            this.comboBoxConversion.Name = "comboBoxConversion";
            this.comboBoxConversion.Size = new System.Drawing.Size(144, 21);
            this.comboBoxConversion.TabIndex = 2;

            this.buttonConvert.Location = new System.Drawing.Point(30, 110);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(100, 30);
            this.buttonConvert.TabIndex = 3;
            this.buttonConvert.Text = "Конвертировать";
            this.buttonConvert.Click += new System.EventHandler(this.buttonConvert_Click);

            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(30, 150);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 13);
            this.labelResult.TabIndex = 4;

            this.ClientSize = new System.Drawing.Size(300, 250);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxTemperature);
            this.Controls.Add(this.comboBoxConversion);
            this.Controls.Add(this.buttonConvert);
            this.Controls.Add(this.labelResult);
            this.Name = "Form2";
            this.Text = "Конвертер Температуры";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}