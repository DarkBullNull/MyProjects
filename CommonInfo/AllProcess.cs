using System;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommonInfo
{
    public partial class AllProcess : Form
    {
        /*-----------------------------*/
        [DllImport("User32.dll")]
        static extern int SetForegroundWindow(IntPtr hWnd);
        public static int HandleProcess { get; private set; }
        /*-----------------------------*/
        Process[] procList = Process.GetProcesses();
        public AllProcess()
        {
            InitializeComponent();
            ToolStripMenuItem terminateMenuItem = new ToolStripMenuItem("Terminate");
            ToolStripMenuItem propertiesMenuItem = new ToolStripMenuItem("Properties");
            contextMenuStrip1.Items.AddRange(new[] { terminateMenuItem, propertiesMenuItem });
            processListBox.ContextMenuStrip = contextMenuStrip1;
            terminateMenuItem.Click += terminateMenuItem_Click;
            propertiesMenuItem.Click += propertiesMenuItem_Click;
        }
        

        void terminateMenuItem_Click(object sender, EventArgs e)
        {
            procList[processListBox.SelectedIndex].Kill();
            
        }
        void propertiesMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Process pro in procList)
            {
                if (pro.ProcessName == processListBox.SelectedItem.ToString())
                try
                {
                    int hWnd = pro.Handle.ToInt32();
                        PCInformation.TerminateProcess(hWnd);
                    break;
                }
                catch
                {

                }
            }
        }

        private void btn_RefreshList_Click(object sender, EventArgs e)
        {
            processListBox.Items.Clear();
            for (int i = 0; i < procList.Length; i++)
            {
                processListBox.Items.Add(procList[i].ToString().Substring(28).Replace(")", string.Empty));
            }
            
        }
    }
}
