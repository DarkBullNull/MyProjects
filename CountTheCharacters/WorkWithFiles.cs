using System.Windows;
using System;
using System.IO;
using Microsoft.Win32;
using System.Linq;
using System.Collections.Generic;

namespace CountTheCharacters
{
    class WorkWithFiles
    {
        public string path { get; private set; }
        public double size { get; private set; }
        public long countLines { get; private set; }

        public void GetPath()
        {
            var lines = new List<string>();
            var mw = new MainWindow();
            var OFD = new OpenFileDialog();
            OFD.Filter = "Текстовый документ(*.txt)|*.txt";
            if (OFD.ShowDialog() != mw.DialogResult.GetValueOrDefault())
            {
                path = OFD.FileName;
                var fi = new FileInfo(path);
                size = Math.Round(Convert.ToDouble(fi.Length)/1024/1024, 2);
                lines = File.ReadLines(path).ToList();
                countLines = lines.Count;
            }
            else
            {
                MessageBox.Show(
                    "Файл не выбран или выбран некорректно", 
                    "Ошибка"
                    );
            }
        }
    }
}
