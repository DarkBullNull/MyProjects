using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrinitySeal;

namespace TrinitySealGUIDE
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            AntiDump.Initialize();
            AntiDebugging();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SealCheck.HashChecks();
           
            if (SealCheck.isValidDLL)
            {
                TrinitySeal.Seal.InitializeForm("kgMKV1psE4yBD31fvxkbuMronNaZtS6haUJzEpvOtB77L", "1.0", "QhBvXsQr5qnwSMtwS76QdKzuK", this, new MainForm(), SealColours.Purple);
            }
        }
        public static async void AntiDebugging()
        {
            reCheck:
            await Task.Delay(2000);
            Anti_DebugNET.AntiDebugTools.Scanner.ScanAndKill();
            goto reCheck;
        }

    }
}
