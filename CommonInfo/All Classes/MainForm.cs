using System;
using System.Diagnostics;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Reflection;

namespace CommonInfo
{
    
    public partial class MainForm : Form
    {
        
        //[DllImport("CppClassDll.dll", SetLastError = true, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
        //public static extern double sumTwo(double var_x, double var_y);
        PerformanceCounter perform = new PerformanceCounter("Processor", "% Processor Time", "_Total");
        FormFileHelper F_FileHelper = new FormFileHelper();
        AllProcess F_AllProcess = new AllProcess();
        int ValueCPU = 0;
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
            FormInfoPC F_InfoPC = new FormInfoPC();
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
            ActivityPCGraph F_Activity = new ActivityPCGraph();
            base.Hide();
            F_Activity.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            /*
            this.plot_CPU.Model = myModel;
            FunctionSeries fs = new FunctionSeries();`
            CPU_TIME();
            if (i == 0)
            {
                Task.Delay(2000);
                CPU_TIME();
                fs.Points.Add(new DataPoint(0, 0));
                fs.Points.Add(new DataPoint(++i, ValueCPU));
            }
            else
            {
                fs.Points.Add(new DataPoint(i, ValueCPU));
                CPU_TIME();
                ValueCPU = Convert.ToInt32(Math.Round(perform.NextValue(), 0));
                fs.Points.Add(new DataPoint(++i, ValueCPU));
            }
            myModel.Series.Add(fs);
        */
        }
        void CPU_TIME()
        {
            ValueCPU = Convert.ToInt32(Math.Round(perform.NextValue(), 0));
        }

        

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
        }
    }
}
