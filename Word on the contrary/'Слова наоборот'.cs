using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simvolperevorot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите последовательность символов: ");
            string word = Console.ReadLine();
            int all = word.Length;
            for (int i = 0; i < all;)
            {
                char[] num = word.ToCharArray(--all, 1);
            Console.Write(num);
            }
            Console.ReadKey();
        }
    }
}
