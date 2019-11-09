using System;

namespace DHM
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество секунд: ");
            int seconds = Convert.ToInt32(Console.ReadLine());
            int minutes = seconds / 60;
            int hours = seconds / 60 / 60;
            if (seconds < 60)
            {
                WriteRes(hours, minutes, seconds);
            }
            else
            {
                int diff;
                if (hours == 0)
                {
                    diff = seconds - (minutes * 60);
                    WriteRes(hours, minutes, diff);
                }
                else
                {
                    if (minutes >= 60)
                    {
                        minutes -= (minutes / 60 * 60);
                        diff = seconds - ((hours * 60 * 60) + minutes * 60);
                        WriteRes(hours, minutes, diff);
                    }
                    else
                    {
                        diff = seconds - ((hours * 60 * 60) + minutes * 60);
                        WriteRes(hours, minutes, diff);
                    }
                }
            }
            Console.ReadKey();
        }
        private static void WriteRes(int hours, int minutes, int seconds) 
            => Console.WriteLine("Прошло часов: " + hours + ", прошло минут: " + minutes + ", прошло секунд " + seconds);
    }
}
