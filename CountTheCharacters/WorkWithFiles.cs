using System.Windows;
using System.IO;
using Microsoft.Win32;

namespace CountTheCharacters
{
    class WorkWithFiles
    {
        public string path { get; private set; }
        public string GetPath()
        {
            var mw = new MainWindow();
            var OFD = new OpenFileDialog();
            OFD.Filter = "Текстовый документ(*.txt)|*.txt";
            if (OFD.ShowDialog() != mw.DialogResult.GetValueOrDefault())
            {
                return path = OFD.FileName;
            }
            else
            {
                return "Файл не выбран или выбран некорректно";
            }
        }
    }
}
