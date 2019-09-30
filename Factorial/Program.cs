using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первоначальное число: ");
            decimal num = Convert.ToDecimal(Console.ReadLine()); // ввожу число с которого начинать вычисление факториала
            Console.WriteLine("Введите счетчик факториала: ");
            decimal kolvo = Convert.ToDecimal(Console.ReadLine()); // ввожу кол-во !P
            Console.ForegroundColor = ConsoleColor.Cyan;
            //Console.WriteLine("--В--Ы--Ч--И--С--Л--Е--Н--И--Е--");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Decimal i = 1m;
            do
            {
                num = (num * i);
                //Console.WriteLine(num); // вывод процесса вычислений(!НЕ ЗАБУДЬ ЗАКОММЕНТИТЬ 17 СТРОКУ!)----->дизайн
                i++;
            }
            while(i<=Convert.ToDecimal(kolvo));


            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Конечный результат: {num}");
            string date = DateTime.Now.ToString();
            Console.ResetColor();
            Console.WriteLine($"Время: { date} ");
            Console.ReadKey();
        }
    }
}
