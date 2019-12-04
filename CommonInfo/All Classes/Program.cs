
using ConversionBack;
using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace CommonInfo
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        static byte[] array;
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
            {
                Setup();
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainForm());
                
            }

        }
        public static void Setup()
        {
            
            if (Debugger.IsAttached)
            {
                // Environment.Exit(0);
            }
            
            using (var stream = Assembly.GetCallingAssembly().GetManifestResourceStream("CommonInfo.RT.dll"))
            {
                using (new StreamReader(stream))
                {
                array = new byte[stream.Length];
                stream.Read(array, 0, array.Length);
                }
            }
            AppDomain.CurrentDomain.AssemblyResolve += ResolveAssembly;
            
        }
        static Assembly ResolveAssembly(object sender, ResolveEventArgs args)
        {
            if (!args.Name.Contains("Runtime"))
            {
                return null;
            }
            return Assembly.Load(array);
        }
    }
}
