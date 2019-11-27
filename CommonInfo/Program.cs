using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommonInfo
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /*
            WindowsPrincipal principal = new WindowsPrincipal(WindowsIdentity.GetCurrent());
            bool hasAdministrativeRight = principal.IsInRole(WindowsBuiltInRole.Administrator);

            if (hasAdministrativeRight == false)
            {
                ProcessStartInfo processInfo = new ProcessStartInfo(); //создаем новый процесс
                processInfo.Verb = "runas"; //в данном случае указываем, что процесс должен быть запущен с правами администратора
                processInfo.FileName = Application.ExecutablePath; //указываем исполняемый файл (программу) для запуска
                try
                {
                    Process.Start(processInfo); //пытаемся запустить процесс
                }
                catch (Win32Exception)
                {
                    MessageBox.Show("Start only with administrator-privilege", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);//Ничего не делаем, потому что пользователь, возможно, нажал кнопку "Нет" в ответ на вопрос о запуске программы в окне предупреждения UAC (для Windows 7)
                }
                Application.Exit(); //закрываем текущую копию программы (в любом случае, даже если пользователь отменил запуск с правами администратора в окне UAC)
            }
            else //имеем права администратора, значит, стартуем
                */
            string path = Environment.CurrentDirectory;
            ProcessStartInfo si = new ProcessStartInfo("cmd.exe");
            si.Arguments = "/C explorer.exe " + path + "\\CommonInfo.exe";
            si.WindowStyle = ProcessWindowStyle.Hidden;
            Process.Start(si);



            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainForm());
            }
        }
    }
}
