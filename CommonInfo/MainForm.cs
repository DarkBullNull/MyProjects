using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommonInfo
{
    
    public partial class MainForm : Form
    {
        PerformanceCounter perform = new PerformanceCounter("Processor", "% Processor Time", "_Total");
        int k = 0;
        PlotModel myModel = new PlotModel { Title = "CPU Usage" };
        FormInfoPC F_InfoPC = new FormInfoPC();
        FormFileHelper F_FileHelper = new FormFileHelper();
        AllProcess F_AllProcess = new AllProcess();
        ActivityPCGraph F_Activity = new ActivityPCGraph();
        
        int i = 0;
        int ValueCPU = 0;
        public MainForm()
        {
            InitializeComponent();
            myModel.Axes.Add(new LinearAxis { Position = AxisPosition.Bottom, Minimum = 0, Maximum = 60 });
            myModel.Axes.Add(new LinearAxis { Position = AxisPosition.Left, Minimum = 0, Maximum = 100 });
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.plot_CPU.Model = myModel;
            FunctionSeries fs = new FunctionSeries();
            //++k;
            fs.Points.Add(new DataPoint(0, 0));
            fs.Points.Add(new DataPoint(++i, ++k));
            myModel.Series.Add(fs);
            fs.Unselect();
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
