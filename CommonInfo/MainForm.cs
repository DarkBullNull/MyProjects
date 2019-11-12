using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace CommonInfo
{
    public partial class MainForm : Form
    {
        FormInfoPC F_InfoPC = new FormInfoPC();
        FormFileHelper F_FileHelper = new FormFileHelper();
        AllProcess F_AllProcess = new AllProcess();
        ActivityPCGraph F_Activity = new ActivityPCGraph();
        readonly PerformanceCounter perform = new PerformanceCounter("Processor", "% Processor Time", "_Total");
        public MainForm()
        {
            InitializeComponent();
            this.Load += (delegate
            {
                pictureBox1.BackColor = Color.White;
                pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            });
            button2.Click += (delegate
            {
                Point[] points = new Point[]
                {
                    new Point{X = pictureBox1.Width / 2, Y = 0},
                };

                Graphics graph = pictureBox1.CreateGraphics();
                Pen pen = new Pen(new SolidBrush(Color.Cyan), 1.0F);

                graph.DrawLine(pen, points[0], points[0]);
                graph.DrawLine(pen, points[0], points[0]);

                Pen pen2 = new Pen(new SolidBrush(Color.Red), 2.0F);

                Point[] myPoints = new Point[]
                {
                    new Point(0,5),
                    new Point(10,10),
                    new Point(20,15),
                    new Point(20,30)
                };

                graph.DrawLines(pen2, myPoints);
            });
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
        }
        private double CPU_TIME()
        {
            return Math.Round(perform.NextValue(), 0);
        }

        
    }
}
