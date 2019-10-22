namespace CommonInfo
{
    partial class FormInfoPC
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_totalRam = new System.Windows.Forms.Label();
            this.label_busyRam = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_totalRam
            // 
            this.label_totalRam.AutoSize = true;
            this.label_totalRam.BackColor = System.Drawing.Color.Black;
            this.label_totalRam.ForeColor = System.Drawing.Color.Cyan;
            this.label_totalRam.Location = new System.Drawing.Point(6, 25);
            this.label_totalRam.Name = "label_totalRam";
            this.label_totalRam.Size = new System.Drawing.Size(72, 13);
            this.label_totalRam.TabIndex = 0;
            this.label_totalRam.Text = "TOTAL_RAM";
            // 
            // label_busyRam
            // 
            this.label_busyRam.AutoSize = true;
            this.label_busyRam.BackColor = System.Drawing.Color.Black;
            this.label_busyRam.ForeColor = System.Drawing.Color.Cyan;
            this.label_busyRam.Location = new System.Drawing.Point(6, 47);
            this.label_busyRam.Name = "label_busyRam";
            this.label_busyRam.Size = new System.Drawing.Size(66, 13);
            this.label_busyRam.TabIndex = 1;
            this.label_busyRam.Text = "BUSY_RAM";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Black;
            this.groupBox1.Controls.Add(this.label_totalRam);
            this.groupBox1.Controls.Add(this.label_busyRam);
            this.groupBox1.ForeColor = System.Drawing.Color.Cyan;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(142, 71);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RAM Memory";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Black;
            this.groupBox2.ForeColor = System.Drawing.Color.Cyan;
            this.groupBox2.Location = new System.Drawing.Point(176, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(416, 219);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "RAM Memory";
            // 
            // FormInfoPC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(782, 378);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormInfoPC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InfoPc";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormInfoPC_FormClosing);
            this.Load += new System.EventHandler(this.FormInfoPC_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_totalRam;
        private System.Windows.Forms.Label label_busyRam;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}