using System;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommonInfo
{
    public partial class AllProcess : Form
    {
        Process[] procList = Process.GetProcesses();
        public AllProcess()
        {
            InitializeComponent();
            refreshListProcess();
            ToolStripMenuItem terminateMenuItem = new ToolStripMenuItem("Terminate");
            ToolStripMenuItem propertiesMenuItem = new ToolStripMenuItem("Properties");
            contextMenuStrip1.Items.AddRange(new[] { terminateMenuItem, propertiesMenuItem });
            listBox1.ContextMenuStrip = contextMenuStrip1;
            terminateMenuItem.Click += terminateMenuItem_Click;
            propertiesMenuItem.Click += propertiesMenuItem_Click;
        }
        

        void terminateMenuItem_Click(object sender, EventArgs e)
        {
            procList[listBox1.SelectedIndex].Kill();
        }
        void propertiesMenuItem_Click(object sender, EventArgs e)
        {

        }

        async void refreshListProcess()
        {
        Refresh:
            listBox1.Items.Clear();
            for (int i = 0; i < procList.Length; i++)
            {
                listBox1.Items.Add(procList[i].ToString().Substring(28).Replace(")", string.Empty));

            }
            await Task.Delay(1000);
            goto Refresh;
        }
    }
}
