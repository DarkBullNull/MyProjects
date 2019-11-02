using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace CommonInfo
{
    public partial class ActivityPCGraph : Form
    {
        public ActivityPCGraph()
        {
            InitializeComponent();
        }

        private void ActivityPCGraph_Load(object sender, EventArgs e)
        {
            PerformanceCounter ramCounter = new PerformanceCounter("Memory", "Available MBytes");
            label1.Text = (ramCounter.NextValue().ToString() + "Mb");
        }
    }
}
