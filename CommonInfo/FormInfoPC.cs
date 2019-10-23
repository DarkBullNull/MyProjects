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
            label_useRam.Text = "UseRAM: " + infoPC.useRAMGlobal + " Mb" + " (" + infoPC.percentUseRAMGlobal + "%)";
            label_captionWin.Text = infoPC.captionGlobal + " (" + infoPC.OSArchitectureGlobal + ")" + " | Build(" + infoPC.versionGlobal + ")";
            label_totalVirtualMemory.Text = "TotalVirtualMemory: " + infoPC.totalVirtualMemoryGlobal + " Mb";
            label_selectedVirtualMemory.Text = "SelectedVirtualMemory: " + infoPC.selectedVirtualMemoryGlobal + 
                " Mb" + " (" + infoPC.percentUseVirtualMemoryGlobal + "%)";
            label_captionProcessor.Text = "CPU Name: " + infoPC.processorNameGlobal;
            label_numCores.Text = "Count Cores: " + infoPC.numberOfCoresGlobal;
            label_nameUser.Text = "User Name: " + infoPC.nameUserGlobal;
            label_nameComputer.Text = "Computer Name: " + infoPC.nameComputerGlobal;
            label_productKey.Text = "Product-key: " + infoPC.serialNumberGlobal;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var F_Main = new MainForm();
            F_Main.Show();
            this.Hide();
        }
    }
}
