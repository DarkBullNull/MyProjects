using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace CommonInfo
{
    public partial class ActivityPCGraph : Form
    {
        PerformanceCounter perform = new PerformanceCounter("Processor", "% Processor Time", "_Total");
        public ActivityPCGraph()
        {
            InitializeComponent();
        }

        private void ActivityPCGraph_Load(object sender, EventArgs e)
        {
            //PerformanceCounter ramCounter = new PerformanceCounter("Memory", "Available MBytes");
            //label1.Text = (ramCounter.NextValue().ToString() + "Mb");
        }
        public string CPU_TIME()
        {
            return Math.Round(perform.NextValue(), 0) + "%";
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            var F_Main = new MainForm();
            F_Main.Show();
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = "Cpu Time: " + CPU_TIME();
            
        }
        
    }
}
