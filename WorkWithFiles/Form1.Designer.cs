namespace WorkWithFiles
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
            this.LoadBase = new System.Windows.Forms.Button();
            this.LoadProxy = new System.Windows.Forms.Button();
            this.BtnStart = new System.Windows.Forms.Button();
            this.BtnStop = new System.Windows.Forms.Button();
            this.CountThreads = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // LoadBase
            // 
            this.LoadBase.Location = new System.Drawing.Point(12, 12);
            this.LoadBase.Name = "LoadBase";
            this.LoadBase.Size = new System.Drawing.Size(130, 34);
            this.LoadBase.TabIndex = 0;
            this.LoadBase.Text = "Загрузить базу";
            this.LoadBase.UseVisualStyleBackColor = true;
            // 
            // LoadProxy
            // 
            this.LoadProxy.Location = new System.Drawing.Point(12, 52);
            this.LoadProxy.Name = "LoadProxy";
            this.LoadProxy.Size = new System.Drawing.Size(130, 34);
            this.LoadProxy.TabIndex = 1;
            this.LoadProxy.Text = "Загрузить прокси";
            this.LoadProxy.UseVisualStyleBackColor = true;
            // 
            // BtnStart
            // 
            this.BtnStart.Location = new System.Drawing.Point(148, 12);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(130, 34);
            this.BtnStart.TabIndex = 2;
            this.BtnStart.Text = "Старт";
            this.BtnStart.UseVisualStyleBackColor = true;
            // 
            // BtnStop
            // 
            this.BtnStop.Location = new System.Drawing.Point(148, 52);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(130, 34);
            this.BtnStop.TabIndex = 3;
            this.BtnStop.Text = "Стоп";
            this.BtnStop.UseVisualStyleBackColor = true;
            // 
            // CountThreads
            // 
            this.CountThreads.Location = new System.Drawing.Point(148, 92);
            this.CountThreads.Multiline = true;
            this.CountThreads.Name = "CountThreads";
            this.CountThreads.Size = new System.Drawing.Size(130, 21);
            this.CountThreads.TabIndex = 4;
            this.CountThreads.Text = "Потоков";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(294, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Хороших аккаунтов: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(294, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Плохих аккаунтов: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(475, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Загружено аккаунтов: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(475, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Загружено прокси: ";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "HTTP(S)",
            "SOCKS-4",
            "SOCKS-5"});
            this.comboBox1.Location = new System.Drawing.Point(12, 92);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(130, 21);
            this.comboBox1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(669, 129);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CountThreads);
            this.Controls.Add(this.BtnStop);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.LoadProxy);
            this.Controls.Add(this.LoadBase);
            this.Name = "Form1";
            this.Text = "MailBrute";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoadBase;
        private System.Windows.Forms.Button LoadProxy;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.Button BtnStop;
        private System.Windows.Forms.TextBox CountThreads;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

