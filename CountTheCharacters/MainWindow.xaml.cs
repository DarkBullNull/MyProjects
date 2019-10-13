using System.Windows;
using System.IO;
using Microsoft.Win32;

namespace CountTheCharacters
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var gf = new WorkWithFiles();
            gf.GetPath();
            CountLines.Content = "Количество строк: " + gf.countLines;
            SizeFile.Content = "Размер файла: " + gf.size.ToString() + " Мбайт";
        }
        private void Window_Closed(object sender, System.EventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
