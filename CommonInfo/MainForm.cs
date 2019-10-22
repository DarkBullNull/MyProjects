using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommonInfo
{
    public partial class MainForm : Form
    {
        FormInfoPC F_InfoPC = new FormInfoPC();
        public MainForm()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void btn_openInfo_Click(object sender, EventArgs e)
        {
            base.Hide();
            F_InfoPC.Show();
        }
    }
}
