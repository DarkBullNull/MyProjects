using System;
using System.IO;
using System.Windows.Forms;


namespace CommonInfo
{
    public partial class FormFileHelper : Form
    {
        public FormFileHelper()
        {
            InitializeComponent();
        }

        private void btn_exitFormPCInfo_Click(object sender, EventArgs e)
        {
            var F_Main = new MainForm();
            F_Main.Show();
            this.Hide();
        }
        
        private void btn_OpenFile_Click(object sender, EventArgs e)
        {
            var filePath = string.Empty;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;
                    var infoFile = new FileInformation(filePath);
                    var encoding = new Encoding(filePath);
                    /*---INFOFILE---*/
                    label_extension.Text = infoFile.extension;
                    label_path.Text = infoFile.pathFullName;
                    label_creationTime.Text = infoFile.creation_Time;
                    label_lastAccessTime.Text = infoFile.lastAccessTime;
                    label_lastWriteTime.Text = infoFile.lastWriteTime;
                    label_size.Text = infoFile.size;
                    /*---ENCODING---*/
                    label_sha1.Text = "SHA-1: " + encoding.SHA1;
                    label_sha256.Text = "SHA-256: " + encoding.SHA256;
                    label_md5.Text = "MD5: " + encoding.MD5;
                    this.Width = 560;
                    this.Height = 260;

                }
                else
                {
                    MessageBox.Show("File Path Empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_FormInfoPC_back_Click(object sender, EventArgs e)
        {
            var F_Main = new MainForm();
            F_Main.Show();
            this.Hide();
        }
    }
}
