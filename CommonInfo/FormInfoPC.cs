using System;
using Microsoft.Win32;
using System.Windows.Forms;
using NvAPIWrapper.GPU;
using System.Text;

namespace CommonInfo
{
    public partial class FormInfoPC : Form
    {
        private readonly StringBuilder sb = new StringBuilder();

        
        public FormInfoPC()
        {
            InitializeComponent();
        }

        private void FormInfoPC_Load(object sender, EventArgs e)
        {
            var infoPC = new PCInformation();
            string releaseId = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion", "ReleaseId", "").ToString(); // ~1809 version windows
            label_totalRam.Text = "TotalRAM: " + infoPC.totalRAMGlobal + " Mb";
            label_useRam.Text = "UseRAM: " + infoPC.useRAMGlobal + " Mb" + " (" + infoPC.percentUseRAMGlobal + "%)";
            label_captionWin.Text = infoPC.captionWindowsGlobal + " (" + infoPC.OSArchitectureGlobal + ")" + " | Version: " + releaseId + " | Build(" + infoPC.versionGlobal + ")";
            label_totalVirtualMemory.Text = "TotalVirtualMemory: " + infoPC.totalVirtualMemoryGlobal + " Mb";
            label_selectedVirtualMemory.Text = "SelectedVirtualMemory: " + infoPC.selectedVirtualMemoryGlobal + 
                " Mb" + " (" + infoPC.percentUseVirtualMemoryGlobal + "%)";
            label_captionProcessor.Text = "CPU Name: " + infoPC.captionProcessorGlobal;
            label_numCores.Text = "Count Cores: " + infoPC.numberOfCoresGlobal;
            label_nameUser.Text = "User Name: " + infoPC.nameUserGlobal;
            label_nameComputer.Text = "Computer Name: " + infoPC.nameComputerGlobal;
            label_productKey.Text = "Product-key: " + infoPC.serialNumberGlobal;
            label_captionMotherBoard.Text = "Model: " + infoPC.captionMotherBoardGlobal;
            label_companyMotherBoard.Text = infoPC.companyMotherBoardGlobal;
            label_captionVideoCard.Text = infoPC.captionVideoAdapterGlobal;
            if (infoPC.captionVideoAdapterGlobal.Contains("NVIDIA"))
            {
                object[] GPU_Info = PhysicalGPU.GetPhysicalGPUs();
                var MemoryInformation = GPU_Info[0].GetType().GetProperty("MemoryInformation").GetValue(GPU_Info[0]);
                label_CoolerInforamtion.Text = "Cooler: " + GPU_Info[0].GetType().GetProperty("CoolerInformation").GetValue(GPU_Info[0]) + "\n";
                label_BusInfromation.Text = GPU_Info[0].GetType().GetProperty("BusInformation").GetValue(GPU_Info[0]) + "\n";
                label_MemoryInformation.Text = "Memory: " + "~" +
                    (Convert.ToDouble(
                    MemoryInformation
                    .GetType()
                    .GetProperty("AvailableDedicatedVideoMemoryInkB")
                    .GetValue(MemoryInformation))
                    /1024)
                    .ToString()
                    + " Mb";
                label_RAMMake.Text = "RAM Maker: " + 
                    (
                    MemoryInformation
                    .GetType()
                    .GetProperty("RAMMaker")
                    .GetValue(MemoryInformation)
                    )
                    .ToString();
                label_RAMType.Text = "RAM Type: " +
                    (
                    MemoryInformation
                    .GetType()
                    .GetProperty("RAMType")
                    .GetValue(MemoryInformation)
                    )
                    .ToString();

            }
            else
            {
                MessageBox.Show("///GPU-Info work only NVIDIA-family///", "Err0R");
                MainForm mf = new MainForm();
                mf.Show();
            }
        }

        private void btn_exitFormPCInfo_Click(object sender, EventArgs e)
        {
            var F_Main = new MainForm();
            F_Main.Show();
            this.Hide();
        }
    }
}
