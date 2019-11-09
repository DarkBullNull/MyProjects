using System;

namespace Bubble_sort
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите количество чисел: ");
                int nums = Convert.ToInt32(Console.ReadLine());
                double[] mass = new double[nums + 1];
                for (int i = 0; i < nums; i++)
                {
                    Console.WriteLine($"Введите {i + 1} элемент: ");
                    mass[i] = Convert.ToDouble(Console.ReadLine());
                }
                Console.WriteLine("...ВЫПОЛНЯЮ СОРТИРОВКУ ПУЗЫРЬКОМ...");
                Sort(mass, nums);
                MassOutputReady(mass, nums);
            }
            catch (Exception)
            {
                Console.WriteLine("Что-то не так!..");
            }
            Console.ReadKey();
        }
		// GOTO FOOOFOFOFOFOFOOFOFOFOFOFOF
        static void Sort(double[] mass, int length)
        {
            for (int i = 0, j = 0; i < length; i++, j = 0)
            {
                reCheck:
                if (j < length - 1)
                {
                    if ((mass[j] > mass[j + 1]))
                    {
                        double temp = mass[j];
                        mass[j] = mass[j + 1];
                        mass[j + 1] = temp;
                        j++;
                        goto reCheck;
                    }
                    else
                    {
                        j = 0;
                        reCheck2:
                        if (mass[j] <= mass[j + 1])
                        {
                            j++;
                            goto reCheck2;
                        }
                        else goto reCheck;
                    }
                }
            }
            

        }
        static void MassOutputReady(double[] mass, int length)
        {
            for (int i = 0; i < length; i++)
            {
                Console.Write(mass[i] + " ");
            }
        }
    }
    }
    


