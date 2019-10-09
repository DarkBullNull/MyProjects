using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHM
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество секунд: ");
            int seconds = Convert.ToInt32(Console.ReadLine());
            int minutes = seconds/60;
            int hours = seconds/60/60;
            int diff;
            if (seconds < 60)
            {
                Console.WriteLine("Прошло часов: " + hours + ", прошло минут: " + minutes + ", прошло секунд " + seconds);
            }
            else
            {
                if (hours == 0)
	            {
                    diff = seconds - (minutes * 60);
                    Console.WriteLine("Прошло часов: " + hours + ", прошло минут: " + minutes + ", прошло секунд " + diff);
	            }
                else
                {
                    if (minutes >= 60)
                    {
                        minutes = (minutes - ((minutes / 60) * 60));
                        diff = seconds - (hours * 60 * 60 + minutes * 60);
                        Console.WriteLine("Прошло часов: " + hours + ", прошло минут: " + minutes + ", прошло секунд " + diff);
                    }
                    else
                    {
                        diff = seconds - (hours * 60 * 60 + minutes * 60);
                        Console.WriteLine("Прошло часов: " + hours + ", прошло минут: " + minutes + ", прошло секунд " + diff);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
