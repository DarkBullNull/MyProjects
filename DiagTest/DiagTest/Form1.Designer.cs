namespace DiagTest
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb1_Input = new System.Windows.Forms.TextBox();
            this.label_info = new System.Windows.Forms.Label();
            this.btn_ok = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutByToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainImage = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainImage)).BeginInit();
            this.SuspendLayout();
            // 
            // tb1_Input
            // 
            this.tb1_Input.Location = new System.Drawing.Point(260, 27);
            this.tb1_Input.Name = "tb1_Input";
            this.tb1_Input.Size = new System.Drawing.Size(115, 20);
            this.tb1_Input.TabIndex = 0;
            // 
            // label_info
            // 
            this.label_info.AutoSize = true;
            this.label_info.Location = new System.Drawing.Point(168, 30);
            this.label_info.Name = "label_info";
            this.label_info.Size = new System.Drawing.Size(86, 13);
            this.label_info.TabIndex = 2;
            this.label_info.Text = "Введите ответ: ";
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(381, 27);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(97, 20);
            this.btn_ok.TabIndex = 3;
            this.btn_ok.Text = "Ответить";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(639, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutByToolStripMenuItem});
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.infoToolStripMenuItem.Text = "Info";
            // 
            // aboutByToolStripMenuItem
            // 
            this.aboutByToolStripMenuItem.Name = "aboutByToolStripMenuItem";
            this.aboutByToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.aboutByToolStripMenuItem.Text = "About the author";
            this.aboutByToolStripMenuItem.Click += new System.EventHandler(this.aboutByToolStripMenuItem_Click);
            // 
            // mainImage
            // 
            this.mainImage.Location = new System.Drawing.Point(0, 53);
            this.mainImage.Name = "mainImage";
            this.mainImage.Size = new System.Drawing.Size(639, 206);
            this.mainImage.TabIndex = 1;
            this.mainImage.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(639, 258);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.label_info);
            this.Controls.Add(this.mainImage);
            this.Controls.Add(this.tb1_Input);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Тестирование(Диаграммы)";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb1_Input;
        private System.Windows.Forms.PictureBox mainImage;
        private System.Windows.Forms.Label label_info;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutByToolStripMenuItem;
    }
}

