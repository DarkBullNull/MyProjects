using System;
using System.Management;
using System.Windows.Forms;

namespace CommonInfo
{
    public partial class FormInfoPC : Form
    {
        public FormInfoPC()
        {
            InitializeComponent();
        }

        private void FormInfoPC_FormClosing(object sender, FormClosingEventArgs e)
        {
            var F_Main = new MainForm();
            F_Main.Show();
        }

        private void FormInfoPC_Load(object sender, EventArgs e)
        {
            var infoPC = new PCInformation();
            label_totalRam.Text = "TotalRAM: " + infoPC.totalRAM + " Mb";
            label_busyRam.Text = "BusyRAM: " + infoPC.busyRAM + " Mb" + " (" + infoPC.percentBusyRAM + "%)";
        }
    }
}
