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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btn_RefreshList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // processListBox
            // 
            this.processListBox.BackColor = System.Drawing.Color.Black;
            this.processListBox.ContextMenuStrip = this.contextMenuStrip1;
            this.processListBox.ForeColor = System.Drawing.Color.Cyan;
            this.processListBox.FormattingEnabled = true;
            this.processListBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.processListBox.Location = new System.Drawing.Point(12, 12);
            this.processListBox.Name = "processListBox";
            this.processListBox.Size = new System.Drawing.Size(295, 160);
            this.processListBox.Sorted = true;
            this.processListBox.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btn_RefreshList
            // 
            this.btn_RefreshList.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btn_RefreshList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_RefreshList.Location = new System.Drawing.Point(12, 178);
            this.btn_RefreshList.Name = "btn_RefreshList";
            this.btn_RefreshList.Size = new System.Drawing.Size(83, 23);
            this.btn_RefreshList.TabIndex = 3;
            this.btn_RefreshList.Text = "Refresh list";
            this.btn_RefreshList.UseVisualStyleBackColor = false;
            this.btn_RefreshList.Click += new System.EventHandler(this.btn_RefreshList_Click);
            // 
            // AllProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(319, 212);
            this.Controls.Add(this.btn_RefreshList);
            this.Controls.Add(this.processListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AllProcess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AllProcess";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox processListBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btn_RefreshList;
    }
}