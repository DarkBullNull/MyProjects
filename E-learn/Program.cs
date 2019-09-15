using System;

namespace E_learn
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Newr:
            Console.Write("Введите число: ");
            try
            {
                int num = Convert.ToInt32(Console.ReadLine());
                string check = num.ToString();
                char[] num1 = check.ToCharArray();
                if (((check.Length == 6) & (num > 0)) | ((num < 0) & (check.Length == 7)))
                {
                    Console.WriteLine($"Первое число: " + num1[0] + "\nТретье число: " + num1[2] + "\nШестое число: " + num1[5]);
                }
                else
                {
                    Console.WriteLine("В числе должно быть 6 символов!");
                    goto Newr;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Введи число!");
                goto Newr;
            }
            Console.ReadKey();
        }
    }
}
