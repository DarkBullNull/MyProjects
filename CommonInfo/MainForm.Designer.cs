namespace CommonInfo
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_openInfo = new System.Windows.Forms.Button();
            this.btn_FileHelperShow = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button_ActivityPC = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_exit.Location = new System.Drawing.Point(-1, 270);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(181, 28);
            this.btn_exit.TabIndex = 0;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_openInfo
            // 
            this.btn_openInfo.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btn_openInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_openInfo.Location = new System.Drawing.Point(2, 3);
            this.btn_openInfo.Name = "btn_openInfo";
            this.btn_openInfo.Size = new System.Drawing.Size(83, 23);
            this.btn_openInfo.TabIndex = 1;
            this.btn_openInfo.Text = "PC_INFO";
            this.btn_openInfo.UseVisualStyleBackColor = false;
            this.btn_openInfo.Click += new System.EventHandler(this.btn_openInfo_Click);
            // 
            // btn_FileHelperShow
            // 
            this.btn_FileHelperShow.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btn_FileHelperShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_FileHelperShow.Location = new System.Drawing.Point(93, 3);
            this.btn_FileHelperShow.Name = "btn_FileHelperShow";
            this.btn_FileHelperShow.Size = new System.Drawing.Size(83, 23);
            this.btn_FileHelperShow.TabIndex = 2;
            this.btn_FileHelperShow.Text = "FILE_INFO";
            this.btn_FileHelperShow.UseVisualStyleBackColor = false;
            this.btn_FileHelperShow.Click += new System.EventHandler(this.btn_FileHelperShow_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(2, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "ALL_PROCESS";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_ActivityPC
            // 
            this.button_ActivityPC.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.button_ActivityPC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_ActivityPC.Location = new System.Drawing.Point(2, 61);
            this.button_ActivityPC.Name = "button_ActivityPC";
            this.button_ActivityPC.Size = new System.Drawing.Size(174, 23);
            this.button_ActivityPC.TabIndex = 4;
            this.button_ActivityPC.Text = "ACTIVITY_PC";
            this.button_ActivityPC.UseVisualStyleBackColor = false;
            this.button_ActivityPC.Click += new System.EventHandler(this.button_ActivityPC_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(407, 61);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(794, 524);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button_ActivityPC);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_FileHelperShow);
            this.Controls.Add(this.btn_openInfo);
            this.Controls.Add(this.btn_exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Opacity = 0.8D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Poooof";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_openInfo;
        private System.Windows.Forms.Button btn_FileHelperShow;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_ActivityPC;
        private OxyPlot.WindowsForms.PlotView plot_CPU;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button2;
    }
}

