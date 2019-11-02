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
        FormFileHelper F_FileHelper = new FormFileHelper();
        AllProcess F_AllProcess = new AllProcess();
        ActivityPCGraph F_Activity = new ActivityPCGraph();
        public MainForm()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void btn_FileHelperShow_Click(object sender, EventArgs e)
        {
            base.Hide();
            F_FileHelper.Show();
        }

        private void btn_openInfo_Click(object sender, EventArgs e)
        {
            base.Hide();
            F_InfoPC.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            base.Hide();
            F_AllProcess.Show();
        }

        private void button_ActivityPC_Click(object sender, EventArgs e)
        {
            base.Hide();
            F_Activity.Show();
        }
    }
}
