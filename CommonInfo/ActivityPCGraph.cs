using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
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
        PerformanceCounter perform = new PerformanceCounter("Processor", "% Processor Time", "_Total");
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
            object[] o = PhysicalGPU.GetPhysicalGPUs();
            //int lengthO = o.Length - 1;
            //richTextBox1.Text = o[lengthO].ToString();
            //richTextBox1.Text = o[0].GetType().GetProperties().ToString();

            foreach (var p in o[0].GetType().GetProperties().Where(p => !p.GetGetMethod().GetParameters().Any()))
            {
                richTextBox1.Text += p.GetValue(o[0]) + "\n";
            }
        }
    }
}
