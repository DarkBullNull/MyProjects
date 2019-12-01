namespace CommonInfo
{
    partial class FormFileHelper
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
            this.btn_OpenFile = new System.Windows.Forms.Button();
            this.label_extension = new System.Windows.Forms.Label();
            this.label_path = new System.Windows.Forms.Label();
            this.label_creationTime = new System.Windows.Forms.Label();
            this.label_lastAccessTime = new System.Windows.Forms.Label();
            this.label_lastWriteTime = new System.Windows.Forms.Label();
            this.label_size = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_md5 = new System.Windows.Forms.Label();
            this.label_sha256 = new System.Windows.Forms.Label();
            this.label_sha1 = new System.Windows.Forms.Label();
            this.btn_FormInfoPC_back = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_OpenFile
            // 
            this.btn_OpenFile.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btn_OpenFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_OpenFile.Location = new System.Drawing.Point(8, 6);
            this.btn_OpenFile.Name = "btn_OpenFile";
            this.btn_OpenFile.Size = new System.Drawing.Size(98, 27);
            this.btn_OpenFile.TabIndex = 8;
            this.btn_OpenFile.Text = "OPEN_FILE";
            this.btn_OpenFile.UseVisualStyleBackColor = false;
            this.btn_OpenFile.Click += new System.EventHandler(this.btn_OpenFile_Click);
            // 
            // label_extension
            // 
            this.label_extension.AutoSize = true;
            this.label_extension.BackColor = System.Drawing.Color.Black;
            this.label_extension.ForeColor = System.Drawing.Color.Cyan;
            this.label_extension.Location = new System.Drawing.Point(7, 18);
            this.label_extension.Name = "label_extension";
            this.label_extension.Size = new System.Drawing.Size(69, 13);
            this.label_extension.TabIndex = 9;
            this.label_extension.Text = "EXTENSION";
            // 
            // label_path
            // 
            this.label_path.AutoSize = true;
            this.label_path.BackColor = System.Drawing.Color.Black;
            this.label_path.ForeColor = System.Drawing.Color.Cyan;
            this.label_path.Location = new System.Drawing.Point(7, 40);
            this.label_path.Name = "label_path";
            this.label_path.Size = new System.Drawing.Size(36, 13);
            this.label_path.TabIndex = 10;
            this.label_path.Text = "PATH";
            // 
            // label_creationTime
            // 
            this.label_creationTime.AutoSize = true;
            this.label_creationTime.BackColor = System.Drawing.Color.Black;
            this.label_creationTime.ForeColor = System.Drawing.Color.Cyan;
            this.label_creationTime.Location = new System.Drawing.Point(7, 61);
            this.label_creationTime.Name = "label_creationTime";
            this.label_creationTime.Size = new System.Drawing.Size(94, 13);
            this.label_creationTime.TabIndex = 11;
            this.label_creationTime.Text = "CREATION_TIME";
            // 
            // label_lastAccessTime
            // 
            this.label_lastAccessTime.AutoSize = true;
            this.label_lastAccessTime.BackColor = System.Drawing.Color.Black;
            this.label_lastAccessTime.ForeColor = System.Drawing.Color.Cyan;
            this.label_lastAccessTime.Location = new System.Drawing.Point(7, 84);
            this.label_lastAccessTime.Name = "label_lastAccessTime";
            this.label_lastAccessTime.Size = new System.Drawing.Size(114, 13);
            this.label_lastAccessTime.TabIndex = 12;
            this.label_lastAccessTime.Text = "LAST_ACCESS_TIME";
            // 
            // label_lastWriteTime
            // 
            this.label_lastWriteTime.AutoSize = true;
            this.label_lastWriteTime.BackColor = System.Drawing.Color.Black;
            this.label_lastWriteTime.ForeColor = System.Drawing.Color.Cyan;
            this.label_lastWriteTime.Location = new System.Drawing.Point(7, 106);
            this.label_lastWriteTime.Name = "label_lastWriteTime";
            this.label_lastWriteTime.Size = new System.Drawing.Size(108, 13);
            this.label_lastWriteTime.TabIndex = 13;
            this.label_lastWriteTime.Text = "LAST_WRITE_TIME";
            // 
            // label_size
            // 
            this.label_size.AutoSize = true;
            this.label_size.BackColor = System.Drawing.Color.Black;
            this.label_size.ForeColor = System.Drawing.Color.Cyan;
            this.label_size.Location = new System.Drawing.Point(7, 129);
            this.label_size.Name = "label_size";
            this.label_size.Size = new System.Drawing.Size(31, 13);
            this.label_size.TabIndex = 14;
            this.label_size.Text = "SIZE";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_md5);
            this.groupBox1.Controls.Add(this.label_sha256);
            this.groupBox1.Controls.Add(this.label_sha1);
            this.groupBox1.Controls.Add(this.label_extension);
            this.groupBox1.Controls.Add(this.label_path);
            this.groupBox1.Controls.Add(this.label_creationTime);
            this.groupBox1.Controls.Add(this.label_lastAccessTime);
            this.groupBox1.Controls.Add(this.label_lastWriteTime);
            this.groupBox1.Controls.Add(this.label_size);
            this.groupBox1.ForeColor = System.Drawing.Color.Cyan;
            this.groupBox1.Location = new System.Drawing.Point(4, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(552, 217);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File Info";
            // 
            // label_md5
            // 
            this.label_md5.AutoSize = true;
            this.label_md5.BackColor = System.Drawing.Color.Black;
            this.label_md5.ForeColor = System.Drawing.Color.Cyan;
            this.label_md5.Location = new System.Drawing.Point(7, 191);
            this.label_md5.Name = "label_md5";
            this.label_md5.Size = new System.Drawing.Size(30, 13);
            this.label_md5.TabIndex = 17;
            this.label_md5.Text = "MD5";
            // 
            // label_sha256
            // 
            this.label_sha256.AutoSize = true;
            this.label_sha256.BackColor = System.Drawing.Color.Black;
            this.label_sha256.ForeColor = System.Drawing.Color.Cyan;
            this.label_sha256.Location = new System.Drawing.Point(7, 170);
            this.label_sha256.Name = "label_sha256";
            this.label_sha256.Size = new System.Drawing.Size(53, 13);
            this.label_sha256.TabIndex = 16;
            this.label_sha256.Text = "SHA_256";
            // 
            // label_sha1
            // 
            this.label_sha1.AutoSize = true;
            this.label_sha1.BackColor = System.Drawing.Color.Black;
            this.label_sha1.ForeColor = System.Drawing.Color.Cyan;
            this.label_sha1.Location = new System.Drawing.Point(7, 150);
            this.label_sha1.Name = "label_sha1";
            this.label_sha1.Size = new System.Drawing.Size(38, 13);
            this.label_sha1.TabIndex = 15;
            this.label_sha1.Text = "SHA-1";
            // 
            // btn_FormInfoPC_back
            // 
            this.btn_FormInfoPC_back.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btn_FormInfoPC_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_FormInfoPC_back.Location = new System.Drawing.Point(116, 6);
            this.btn_FormInfoPC_back.Name = "btn_FormInfoPC_back";
            this.btn_FormInfoPC_back.Size = new System.Drawing.Size(98, 27);
            this.btn_FormInfoPC_back.TabIndex = 16;
            this.btn_FormInfoPC_back.Text = "Back";
            this.btn_FormInfoPC_back.UseVisualStyleBackColor = false;
            this.btn_FormInfoPC_back.Click += new System.EventHandler(this.btn_FormInfoPC_back_Click);
            // 
            // FormFileHelper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(223, 41);
            this.Controls.Add(this.btn_FormInfoPC_back);
            this.Controls.Add(this.btn_OpenFile);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormFileHelper";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FileHelper";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_OpenFile;
        private System.Windows.Forms.Label label_extension;
        private System.Windows.Forms.Label label_path;
        private System.Windows.Forms.Label label_creationTime;
        private System.Windows.Forms.Label label_lastAccessTime;
        private System.Windows.Forms.Label label_lastWriteTime;
        private System.Windows.Forms.Label label_size;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_md5;
        private System.Windows.Forms.Label label_sha256;
        private System.Windows.Forms.Label label_sha1;
        private System.Windows.Forms.Button btn_FormInfoPC_back;
    }
}