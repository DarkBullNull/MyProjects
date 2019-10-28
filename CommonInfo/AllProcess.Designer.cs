namespace CommonInfo
{
    partial class AllProcess
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
            this.components = new System.ComponentModel.Container();
            this.processListBox = new System.Windows.Forms.ListBox();
            this.contextMenuProcesses = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btn_RefreshList = new System.Windows.Forms.Button();
            this.btn_FormInfoPC_back = new System.Windows.Forms.Button();
            this.label_countProcesses = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // processListBox
            // 
            this.processListBox.BackColor = System.Drawing.Color.Black;
            this.processListBox.ContextMenuStrip = this.contextMenuProcesses;
            this.processListBox.ForeColor = System.Drawing.Color.Cyan;
            this.processListBox.FormattingEnabled = true;
            this.processListBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.processListBox.Location = new System.Drawing.Point(12, 12);
            this.processListBox.Name = "processListBox";
            this.processListBox.Size = new System.Drawing.Size(647, 472);
            this.processListBox.Sorted = true;
            this.processListBox.TabIndex = 0;
            // 
            // contextMenuProcesses
            // 
            this.contextMenuProcesses.Name = "contextMenuStrip1";
            this.contextMenuProcesses.Size = new System.Drawing.Size(61, 4);
            // 
            // btn_RefreshList
            // 
            this.btn_RefreshList.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btn_RefreshList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_RefreshList.Location = new System.Drawing.Point(12, 490);
            this.btn_RefreshList.Name = "btn_RefreshList";
            this.btn_RefreshList.Size = new System.Drawing.Size(83, 23);
            this.btn_RefreshList.TabIndex = 3;
            this.btn_RefreshList.Text = "Refresh list";
            this.btn_RefreshList.UseVisualStyleBackColor = false;
            this.btn_RefreshList.Click += new System.EventHandler(this.btn_RefreshList_Click);
            // 
            // btn_FormInfoPC_back
            // 
            this.btn_FormInfoPC_back.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btn_FormInfoPC_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_FormInfoPC_back.Location = new System.Drawing.Point(576, 490);
            this.btn_FormInfoPC_back.Name = "btn_FormInfoPC_back";
            this.btn_FormInfoPC_back.Size = new System.Drawing.Size(83, 23);
            this.btn_FormInfoPC_back.TabIndex = 17;
            this.btn_FormInfoPC_back.Text = "Back";
            this.btn_FormInfoPC_back.UseVisualStyleBackColor = false;
            this.btn_FormInfoPC_back.Click += new System.EventHandler(this.btn_FormInfoPC_back_Click);
            // 
            // label_countProcesses
            // 
            this.label_countProcesses.AutoSize = true;
            this.label_countProcesses.BackColor = System.Drawing.Color.Black;
            this.label_countProcesses.ForeColor = System.Drawing.Color.Cyan;
            this.label_countProcesses.Location = new System.Drawing.Point(101, 495);
            this.label_countProcesses.Name = "label_countProcesses";
            this.label_countProcesses.Size = new System.Drawing.Size(92, 13);
            this.label_countProcesses.TabIndex = 18;
            this.label_countProcesses.Text = "Count processes: ";
            // 
            // AllProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(671, 525);
            this.Controls.Add(this.label_countProcesses);
            this.Controls.Add(this.btn_FormInfoPC_back);
            this.Controls.Add(this.btn_RefreshList);
            this.Controls.Add(this.processListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AllProcess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AllProcess";
            this.Load += new System.EventHandler(this.AllProcess_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox processListBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuProcesses;
        private System.Windows.Forms.Button btn_RefreshList;
        private System.Windows.Forms.Button btn_FormInfoPC_back;
        private System.Windows.Forms.Label label_countProcesses;
    }
}