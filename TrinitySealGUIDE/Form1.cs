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
            AntiDump.Initialize();// CHECK THIS!!!
            AntiDebugging();// CHECK THIS!!!
            
        }
        public void Form1_Load(object sender, EventArgs e)
        {
            this.Opacity = 0D;
            SealCheck.HashChecks();
            if (SealCheck.isValidDLL)
            {
                {
                    Prch = 1;
                    Seal.InitializeForm(
                    "Your_key",
                     "Version",
                    "VariableSecretKey",
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