using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DiagTest
{
    public partial class MainForm : Form
    {
        CommonStruct cs = new CommonStruct();
        int good = 0;
        int i = 0;
        public MainForm()
        {
            InitializeComponent();
            AntiDump.Initialize();// CHECK THIS!!!
            AntiDebugging();// CHECK THIS!!!
            mainImage.Image = cs.Randomnie[0].Key;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb1_Input.Text == cs.Randomnie[i].Value)
                {
                    ++i;
                    ++good;
                    tb1_Input.Clear();
                    if (i == 5)
                    {
                        MessageBox.Show("Оценка: " + good, "Завершение...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Process.GetCurrentProcess().Kill();
                    }
                    mainImage.Image = null;
                    mainImage.Image = cs.Randomnie[i].Key;
                }
                else
                {
                    ++i;
                    tb1_Input.Clear();
                    if (i == 5)
                    {
                        MessageBox.Show("Оценка: " + good, "Завершение...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Process.GetCurrentProcess().Kill();
                    }
                    mainImage.Image = null;
                    mainImage.Image = cs.Randomnie[i].Key;
                }
            }
            catch (Exception)
            {
                throw;
            }


        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        

        private void aboutByToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Автор(tg): @dbsale", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static async void AntiDebugging()
        {
        reCheck:
            await Task.Delay(2000);
            Scanner.ScanAndKill();
            goto reCheck;
        }
    }
}
