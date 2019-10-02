using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using System.Net;
using xNet;


namespace Bruteforce
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Btn_exit_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(1);
        }
        
        private void Btn_auth_Click(object sender, RoutedEventArgs e)
        {
           
                tb_page.Clear();
                string url = tb_link.Text;
                tb_page.Text = GetPage.GettingPage(url);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string directory = Environment.CurrentDirectory;
            string lines = tb_page.Text;
            File.WriteAllText(directory + @"\html.txt", lines);
            MessageBox.Show("Файл html.txt создан в директории:\n" + 
                            directory,
                     "Успешно",
                            MessageBoxButton.OK,
                       MessageBoxImage.Information);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                string directory = Environment.CurrentDirectory;
                Process.Start(directory + @"\html.txt");
            }
            catch
            {
                MessageBox.Show("Файл не найден", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        
        private void Btn_auth_Click_1(object sender, RoutedEventArgs e)
        {
            string login = tb_login.Text;
            string password = tb_pwd.Text;
            GetPage auth = new GetPage();
           
            if (auth.Post_Auth(login, password)) MessageBox.Show("Успешно авторизован", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
            else MessageBox.Show("Неверная почта/пароль", "Info", MessageBoxButton.OK, MessageBoxImage.Hand);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            // tb_page.Clear();
            // GetPage parse = new GetPage();
            // tb_page.Text = parse.Token_Pars();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

        }

        private void Btn_clearmail_Click(object sender, RoutedEventArgs e)
        {
            tb_login.Text = null;
            tb_pwd.Text = null;
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }
    }
}
