using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число:");
            int result;
            while (!int.TryParse(Console.ReadLine(), out result))
                Console.WriteLine("Input error!");
            Console.ReadKey();
        }
    }
}
