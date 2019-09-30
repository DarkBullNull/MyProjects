using System;

namespace E_learning_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Вводить целые числа и не больше 50, т.к. тип данных Decimal не может принимать большее значение, чем 50^17");
            Console.ResetColor();
            Console.Write("Введите число: ");
            decimal b, c, d, e, f, g, h, a = Convert.ToDecimal(Console.ReadLine());
            b = a;

            // начало возведения в 9 степень
            c = a * a;//  c = a в 2 степени!
            d = c * c;//  d = a в 4 степени!
            e = d * d;//  e = a в 8 степени!
            a = e * a;//  a = a в 9 степени!
            // конец возведения в 9 степень

            Console.WriteLine($"{b}^9 = {a}");

            // начало обнуления
            a = b;
            // конец обнуления

            // начало возведения в 13 степень
            c = a * a;//  c = a в 2 степени!
            d = c * c;//  d = a в 4 степени!
            e = d * d;//  e = a в 8 степени!
            f = e * a;//  f = a в 9 степени!
            a = f * d;//  a = a в 13 степени!
            // конец возведения в 13 степень

            Console.WriteLine($"{b}^13 = {a}");

            // начало обнуления
            a = b;
            // конец обнуления

            // начало возведения в 2, 5, 17 степени
            c = a * a; // c = a в 2 степени!
            d = c * c; // d = a в 4 степени!
            e = d * a; // e = a в 5 степени!
            f = e * e; // f = a в 10 степени!
            g = f * e; // g = a в 15 степени!
            h = g * c; // h = a в 17 степени!

            // конец возведения в 2, 5, 17 степени

            Console.WriteLine($"{b}^2 = {c}, {b}^5 = {e}, {b}^17 = {h}");
            Console.ReadKey();
        }
    }
}
