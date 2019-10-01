using System;

namespace MyFirstDataBase
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new MyDbContext())
            {
                var group = new Group()
                {
                    Name = "Rammstein",
                    Year = 1994
                };

                context.Groups.Add(group); //группа пока в кешированной БД
                context.SaveChanges(); //все изменения из локального хранилища(кешированной БД) уйдут в основную БД

                Console.WriteLine($"id: {group.Id}, name: {group.Name}, year: {group.Year}");
                Console.ReadLine();
            }
        }
    }
}
