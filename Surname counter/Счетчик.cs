using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sotr = { "Иванов", "Петров", "Сидоров", "Борисов", "Сергеев", "Сидоров" };
            int famil = 0;
            foreach (string s in sotr)
            {
                if (s == "Сидоров")
                {
                    famil++;
                    Console.WriteLine(s);
                    continue;
                }
                Console.WriteLine(s);
            }
            Console.WriteLine($"Кол-во Сидоровых: {famil}");
            Console.ReadKey();
        }
    }
}
