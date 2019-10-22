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

        private void FormInfoPC_Load(object sender, EventArgs e)
        {
            var infoPC = new PCInformation();
            label_totalRam.Text = "TotalRAM: " + infoPC.totalRAMGlobal + " Mb";
            label_busyRam.Text = "BusyRAM: " + infoPC.busyRAMGlobal + " Mb" + " (" + infoPC.percentBusyRAMGlobal + "%)";
            label_captionWin.Text = infoPC.CaptionGlobal + " (" + infoPC.OSArchitectureGlobal + ")";
            label_totalVirtualMemory.Text = "TotalVirtualMemory: " + infoPC.totalVirtualMemoryGlobal + " Mb";
            label_selectedVirtualMemory.Text = "SelectedVirtualMemory: " + infoPC.selectedVirtualMemoryGlobal + " Mb" + " (" + infoPC.percentBusyVirtualMemoryGlobal + "%)";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var F_Main = new MainForm();
            F_Main.Show();
            this.Hide();
        }
    }
}
