using System;
using System.Diagnostics;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Reflection;
using ConversionBack;

namespace CommonInfo
{
    
    public partial class MainForm : Form
    {
        PerformanceCounter perform = new PerformanceCounter("Processor", "% Processor Time", "_Total");
        FormFileHelper F_FileHelper = new FormFileHelper();
        AllProcess F_AllProcess = new AllProcess();
        int ValueCPU = 0;
        public MainForm()
        {
            //Initialize.Initalize("CommonInfo.Assembly.dll");
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
            FormInfoPC F_InfoPC = new FormInfoPC();
            base.Hide();
            F_InfoPC.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            base.Hide();
            F_AllProcess.Show();
        }

        
        

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        int CPU_TIME()
        {
            ValueCPU = Convert.ToInt32(Math.Round(perform.NextValue(), 0));
            return ValueCPU;
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            label_percentProcUse.Text = "Cpu Usage: " + CPU_TIME() + "%";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MemoryWork mw = new MemoryWork();
            
        }
    }
}
