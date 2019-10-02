namespace InTradeLine
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.courseDollar = new System.Windows.Forms.Label();
            this.courseEuro = new System.Windows.Forms.Label();
            this.courseBTC = new System.Windows.Forms.Label();
            this.courseETH = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "to";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(8, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(118, 20);
            this.textBox1.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Российский рубль",
            "Доллар США",
            "Евро"});
            this.comboBox1.Location = new System.Drawing.Point(8, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(118, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.Text = "Выберите валюту";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(154, 3);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(118, 21);
            this.comboBox2.TabIndex = 5;
            this.comboBox2.Text = "Выберите валюту";
            // 
            // courseDollar
            // 
            this.courseDollar.AutoSize = true;
            this.courseDollar.Location = new System.Drawing.Point(5, 53);
            this.courseDollar.Name = "courseDollar";
            this.courseDollar.Size = new System.Drawing.Size(82, 13);
            this.courseDollar.TabIndex = 6;
            this.courseDollar.Text = "Курс доллара: ";
            // 
            // courseEuro
            // 
            this.courseEuro.AutoSize = true;
            this.courseEuro.Location = new System.Drawing.Point(5, 70);
            this.courseEuro.Name = "courseEuro";
            this.courseEuro.Size = new System.Drawing.Size(64, 13);
            this.courseEuro.TabIndex = 7;
            this.courseEuro.Text = "Курс евро: ";
            // 
            // courseBTC
            // 
            this.courseBTC.AutoSize = true;
            this.courseBTC.Location = new System.Drawing.Point(5, 87);
            this.courseBTC.Name = "courseBTC";
            this.courseBTC.Size = new System.Drawing.Size(72, 13);
            this.courseBTC.TabIndex = 8;
            this.courseBTC.Text = "Курс Bitcoin: ";
            // 
            // courseETH
            // 
            this.courseETH.AutoSize = true;
            this.courseETH.Location = new System.Drawing.Point(5, 104);
            this.courseETH.Name = "courseETH";
            this.courseETH.Size = new System.Drawing.Size(85, 13);
            this.courseETH.TabIndex = 9;
            this.courseETH.Text = "Курс Ethereum: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 147);
            this.Controls.Add(this.courseETH);
            this.Controls.Add(this.courseBTC);
            this.Controls.Add(this.courseEuro);
            this.Controls.Add(this.courseDollar);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InTradeLine";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label courseDollar;
        private System.Windows.Forms.Label courseEuro;
        private System.Windows.Forms.Label courseBTC;
        private System.Windows.Forms.Label courseETH;
    }
}

