using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace CommonInfo
{
    public partial class AllProcess : Form
    {
        public AllProcess()
        {
            InitializeComponent();
            MenuIndexListBox();
        }
        
        private void AllProcess_Load(object sender, EventArgs e)
        {
            Process[] procList = Process.GetProcesses();
            for (int i = 0; i < procList.Length; i++)
            {
                listBox1.Items.Add(procList[i].ToString().Substring(28).Replace(")", string.Empty));
            }
        }
        private void MenuIndexListBox()
        {
            foreach (object k in listBox1.Items)
            {
                listBox1.ContextMenu.MenuItems.Add("test");
            }
        }

        private void listBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                MenuItem[] menuItems = new MenuItem[]{new MenuItem("Some Button Info"),
                    new MenuItem("Some Other Button Info"), new MenuItem("Exit")};

                ContextMenu buttonMenu = new ContextMenu(menuItems);
                buttonMenu.Show(listBox1, new System.Drawing.Point(e.X, e.Y));
                if (e.Button == MouseButtons.Left)
                {
                    //CODE
                }
            }
        }
    }
}
