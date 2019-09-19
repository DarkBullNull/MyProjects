using System;

namespace E_learning_3
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Recheck:
            try
            {
                double cat1, cat2, gip, ang1, ang2;
                Console.Write("Введите длину первого катета: ");
                cat1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите длину первого катета: ");
                cat2 = Convert.ToInt32(Console.ReadLine());
                if ((cat1 <= 0) | (cat2 <= 0))
                {
                    throw new Exception();
                }
                gip = (Math.Round(Math.Sqrt(cat1 * cat1 + cat2 * cat2), 2));
                Console.WriteLine("Гипотенуза = " + gip);
                ang1 = Math.Round(Math.Asin(cat2 / gip) * (180.0 / Math.PI), 0);
                ang2 = Math.Round(Math.Asin(cat1 / gip) * (180.0 / Math.PI), 0);
                Console.WriteLine("Угол альфа при катете, равном " + cat1 + " =  " + ang1);
                Console.WriteLine("Угол бетта при катете, равном " + cat2 + " =  " + ang2);
                Console.ReadKey();
            }
            catch (Exception)
            {
                Console.WriteLine("Ищи ошибку");
                goto Recheck;
                throw;
            }
        }
    }
}
