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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInfoPC));
            this.label_totalRam = new System.Windows.Forms.Label();
            this.label_useRam = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label_captionWin = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label_totalVirtualMemory = new System.Windows.Forms.Label();
            this.label_selectedVirtualMemory = new System.Windows.Forms.Label();
            this.btn_exitFormPCInfo = new System.Windows.Forms.Button();
            this.label_captionProcessor = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label_numCores = new System.Windows.Forms.Label();
            this.label_nameComputer = new System.Windows.Forms.Label();
            this.label_nameUser = new System.Windows.Forms.Label();
            this.label_productKey = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
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
            // label_useRam
            // 
            this.label_useRam.AutoSize = true;
            this.label_useRam.BackColor = System.Drawing.Color.Black;
            this.label_useRam.ForeColor = System.Drawing.Color.Cyan;
            this.label_useRam.Location = new System.Drawing.Point(6, 47);
            this.label_useRam.Name = "label_useRam";
            this.label_useRam.Size = new System.Drawing.Size(59, 13);
            this.label_useRam.TabIndex = 1;
            this.label_useRam.Text = "USE_RAM";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Black;
            this.groupBox1.Controls.Add(this.label_totalRam);
            this.groupBox1.Controls.Add(this.label_useRam);
            this.groupBox1.ForeColor = System.Drawing.Color.Cyan;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 79);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RAM Memory";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Black;
            this.groupBox2.Controls.Add(this.label_productKey);
            this.groupBox2.Controls.Add(this.label_nameUser);
            this.groupBox2.Controls.Add(this.label_nameComputer);
            this.groupBox2.Controls.Add(this.label_captionWin);
            this.groupBox2.ForeColor = System.Drawing.Color.Cyan;
            this.groupBox2.Location = new System.Drawing.Point(232, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(538, 163);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "About PC";
            // 
            // label_captionWin
            // 
            this.label_captionWin.AutoSize = true;
            this.label_captionWin.BackColor = System.Drawing.Color.Black;
            this.label_captionWin.ForeColor = System.Drawing.Color.Cyan;
            this.label_captionWin.Location = new System.Drawing.Point(6, 25);
            this.label_captionWin.Name = "label_captionWin";
            this.label_captionWin.Size = new System.Drawing.Size(116, 13);
            this.label_captionWin.TabIndex = 1;
            this.label_captionWin.Text = "CAPTION_WINDOWS";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Black;
            this.groupBox3.Controls.Add(this.label_totalVirtualMemory);
            this.groupBox3.Controls.Add(this.label_selectedVirtualMemory);
            this.groupBox3.ForeColor = System.Drawing.Color.Cyan;
            this.groupBox3.Location = new System.Drawing.Point(3, 87);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(223, 79);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Virtual Memory";
            // 
            // label_totalVirtualMemory
            // 
            this.label_totalVirtualMemory.AutoSize = true;
            this.label_totalVirtualMemory.BackColor = System.Drawing.Color.Black;
            this.label_totalVirtualMemory.ForeColor = System.Drawing.Color.Cyan;
            this.label_totalVirtualMemory.Location = new System.Drawing.Point(6, 25);
            this.label_totalVirtualMemory.Name = "label_totalVirtualMemory";
            this.label_totalVirtualMemory.Size = new System.Drawing.Size(64, 13);
            this.label_totalVirtualMemory.TabIndex = 0;
            this.label_totalVirtualMemory.Text = "TOTAL_VM";
            // 
            // label_selectedVirtualMemory
            // 
            this.label_selectedVirtualMemory.AutoSize = true;
            this.label_selectedVirtualMemory.BackColor = System.Drawing.Color.Black;
            this.label_selectedVirtualMemory.ForeColor = System.Drawing.Color.Cyan;
            this.label_selectedVirtualMemory.Location = new System.Drawing.Point(6, 47);
            this.label_selectedVirtualMemory.Name = "label_selectedVirtualMemory";
            this.label_selectedVirtualMemory.Size = new System.Drawing.Size(51, 13);
            this.label_selectedVirtualMemory.TabIndex = 1;
            this.label_selectedVirtualMemory.Text = "USE_VM";
            // 
            // btn_exitFormPCInfo
            // 
            this.btn_exitFormPCInfo.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btn_exitFormPCInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_exitFormPCInfo.Location = new System.Drawing.Point(-7, 354);
            this.btn_exitFormPCInfo.Name = "btn_exitFormPCInfo";
            this.btn_exitFormPCInfo.Size = new System.Drawing.Size(788, 26);
            this.btn_exitFormPCInfo.TabIndex = 6;
            this.btn_exitFormPCInfo.Text = "Close";
            this.btn_exitFormPCInfo.UseVisualStyleBackColor = false;
            this.btn_exitFormPCInfo.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_captionProcessor
            // 
            this.label_captionProcessor.AutoSize = true;
            this.label_captionProcessor.BackColor = System.Drawing.Color.Black;
            this.label_captionProcessor.ForeColor = System.Drawing.Color.Cyan;
            this.label_captionProcessor.Location = new System.Drawing.Point(6, 25);
            this.label_captionProcessor.Name = "label_captionProcessor";
            this.label_captionProcessor.Size = new System.Drawing.Size(127, 13);
            this.label_captionProcessor.TabIndex = 2;
            this.label_captionProcessor.Text = "CAPTION_PROCESSOR";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Black;
            this.groupBox4.Controls.Add(this.label_numCores);
            this.groupBox4.Controls.Add(this.label_captionProcessor);
            this.groupBox4.ForeColor = System.Drawing.Color.Cyan;
            this.groupBox4.Location = new System.Drawing.Point(3, 172);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(351, 79);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "CPU Info";
            // 
            // label_numCores
            // 
            this.label_numCores.AutoSize = true;
            this.label_numCores.BackColor = System.Drawing.Color.Black;
            this.label_numCores.ForeColor = System.Drawing.Color.Cyan;
            this.label_numCores.Location = new System.Drawing.Point(6, 48);
            this.label_numCores.Name = "label_numCores";
            this.label_numCores.Size = new System.Drawing.Size(75, 13);
            this.label_numCores.TabIndex = 3;
            this.label_numCores.Text = "NUM_CORES";
            // 
            // label_nameComputer
            // 
            this.label_nameComputer.AutoSize = true;
            this.label_nameComputer.BackColor = System.Drawing.Color.Black;
            this.label_nameComputer.ForeColor = System.Drawing.Color.Cyan;
            this.label_nameComputer.Location = new System.Drawing.Point(6, 43);
            this.label_nameComputer.Name = "label_nameComputer";
            this.label_nameComputer.Size = new System.Drawing.Size(105, 13);
            this.label_nameComputer.TabIndex = 2;
            this.label_nameComputer.Text = "NAME_COMPUTER";
            // 
            // label_nameUser
            // 
            this.label_nameUser.AutoSize = true;
            this.label_nameUser.BackColor = System.Drawing.Color.Black;
            this.label_nameUser.ForeColor = System.Drawing.Color.Cyan;
            this.label_nameUser.Location = new System.Drawing.Point(6, 62);
            this.label_nameUser.Name = "label_nameUser";
            this.label_nameUser.Size = new System.Drawing.Size(74, 13);
            this.label_nameUser.TabIndex = 3;
            this.label_nameUser.Text = "NAME_USER";
            // 
            // label_productKey
            // 
            this.label_productKey.AutoSize = true;
            this.label_productKey.BackColor = System.Drawing.Color.Black;
            this.label_productKey.ForeColor = System.Drawing.Color.Cyan;
            this.label_productKey.Location = new System.Drawing.Point(6, 81);
            this.label_productKey.Name = "label_productKey";
            this.label_productKey.Size = new System.Drawing.Size(87, 13);
            this.label_productKey.TabIndex = 4;
            this.label_productKey.Text = "PRODUCT_KEY";
            // 
            // FormInfoPC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(773, 378);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btn_exitFormPCInfo);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormInfoPC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InfoPc";
            this.Load += new System.EventHandler(this.FormInfoPC_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_totalRam;
        private System.Windows.Forms.Label label_useRam;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label_captionWin;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label_totalVirtualMemory;
        private System.Windows.Forms.Label label_selectedVirtualMemory;
        private System.Windows.Forms.Button btn_exitFormPCInfo;
        private System.Windows.Forms.Label label_captionProcessor;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label_numCores;
        private System.Windows.Forms.Label label_nameComputer;
        private System.Windows.Forms.Label label_nameUser;
        private System.Windows.Forms.Label label_productKey;
    }
}