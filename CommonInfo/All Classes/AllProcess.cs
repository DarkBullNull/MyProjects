using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CommonInfo
{
    public partial class AllProcess : Form
    {

        /*-----------------------------*/
        [DllImport("winsta.dll", SetLastError = true)]
        private static extern bool WinStationTerminateProcess(IntPtr hServer, ulong ProcessId, ulong ExitCode);
        /*-----------------------------*/
        public AllProcess()
        {
            InitializeComponent();
            ToolStripMenuItem terminateMenuItem = new ToolStripMenuItem("Terminate");
            ToolStripMenuItem propertiesMenuItem = new ToolStripMenuItem("Properties");
            contextMenuProcesses.Items.AddRange(new[] { terminateMenuItem, propertiesMenuItem });
            processListBox.ContextMenuStrip = contextMenuProcesses;
            terminateMenuItem.Click += terminateMenuItem_Click;
            propertiesMenuItem.Click += propertiesMenuItem_Click;
        }

        void terminateMenuItem_Click(object sender, EventArgs e)
        {
            Process[] procList = Process.GetProcesses();
            foreach (Process pro in procList)
            {
                if (pro.ProcessName == processListBox.SelectedItem.ToString())
                {
                    try
                    {
                        ulong pId = (ulong)pro.Id;
                        WinStationTerminateProcess(IntPtr.Zero, pId, 1);
                        break;
                    }
                    catch
                    {
                        MessageBox.Show("Error", "!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            label_countProcessesNum.Text = procList.Length.ToString();
        }
        void propertiesMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void btn_RefreshList_Click(object sender, EventArgs e)
        {
            Process[] procList = Process.GetProcesses();
            label_countProcessesNum.Text = procList.Length.ToString();
            processListBox.Items.Clear();
            for (int i = 0; i < procList.Length; i++)
            {
                processListBox.Items.Add(procList[i].ToString().Substring(28).Replace(")", string.Empty));
            }

        }

        private void btn_FormInfoPC_back_Click(object sender, EventArgs e)
        {
            var F_Main = new MainForm();
            F_Main.Show();
            this.Hide();
        }

        private void AllProcess_Load(object sender, EventArgs e)
        {
            Process[] procList = Process.GetProcesses();
            label_countProcessesNum.Text = procList.Length.ToString();
            for (int i = 0; i < procList.Length; i++)
            {
                processListBox.Items.Add(procList[i].ToString().Substring(28).Replace(")", string.Empty));
            }
        }
    }
}
