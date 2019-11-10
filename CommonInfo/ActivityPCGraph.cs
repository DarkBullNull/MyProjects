using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using NvAPIWrapper;
using NvAPIWrapper.Display;
using NvAPIWrapper.GPU;
using NvAPIWrapper.Mosaic;
using NvAPIWrapper.Native;

namespace CommonInfo
{
    public partial class ActivityPCGraph : Form
    {
        private readonly StringBuilder sb = new StringBuilder();
        private readonly object[] GPU_Info = PhysicalGPU.GetPhysicalGPUs();
        readonly PCInformation infoPC = new PCInformation();
        readonly PerformanceCounter perform = new PerformanceCounter("Processor", "% Processor Time", "_Total");
        public ActivityPCGraph()
        {
            InitializeComponent();
           
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
            label_percentProcUse.Text = "Cpu Time: " + CPU_TIME();
            
        }

        private void ActivityPCGraph_Load(object sender, EventArgs e)
        {
            if (infoPC.captionVideoAdapterGlobal.Contains("NVIDIA"))
            {
                sb.Append((GPU_Info[0].GetType().GetProperty("FullName").GetValue(GPU_Info[0], null)) + "\n");
                sb.Append((GPU_Info[0].GetType().GetProperty("Board").GetValue(GPU_Info[0], null)) + "\n");
                MessageBox.Show(sb.ToString());
            }
            else
            {
                MessageBox.Show("///Work only NVIDIA-family///", "Err0R");
            }
        }
        public static object GetPropValue(object src, string propName)
        {
            return src.GetType().GetProperty(propName).GetValue(src, null);
        }
    }
}
