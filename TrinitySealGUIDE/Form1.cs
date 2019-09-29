using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrinitySeal;

namespace TrinitySealGUIDE
{

    public partial class Form1 : Form
    {
        public static int Prch { get; private set; }
        public Form1()
        {
            InitializeComponent();
            //AntiDump.Initialize();
            //AntiDebugging();
            
        }
        public void Form1_Load(object sender, EventArgs e)
        {
            this.Opacity = 0D;
            SealCheck.HashChecks();
            Seal.GrabVariables("QhBvXsQr5qnwSMtwS76QdKzuK", "kgMKV1psE4yBD31fvxkbuMronNaZtS6haUJzEpvOtB77L", "Dark_Bull", "7580545910");
            Seal.Initialize("1.1");
            if (SealCheck.isValidDLL)
            {
                if (ProgramVariables.Freemode)
                {
                    var mf = new MainForm();
                    mf.Show();
                    mf.Dispose();
                }
                else
                {
                    Prch = 1;
                    Seal.InitializeForm(
                    "kgMKV1psE4yBD31fvxkbuMronNaZtS6haUJzEpvOtB77L",
                     "1.1",
                    "QhBvXsQr5qnwSMtwS76QdKzuK",
                    this, new MainForm(),
                    SealColours.Purple);
                }
            }
            else Prch = 0;
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