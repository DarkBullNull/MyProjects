using System;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Security.Cryptography;
using System.Text;
using System.Windows;

namespace HashDoDoHash
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter path: ");
            string path = Console.ReadLine();
            path = path.Replace('"', ' ');
            new Encoding(path);
            new FileInformation(path);
            Console.ReadKey();
        }
        
        
    }
}
