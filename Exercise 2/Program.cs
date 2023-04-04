using System;
using System.Text;

namespace Exercise_2
{
    struct Worker
    {
        public string LastName { get; set; }
        public string Initials { get; set; }
        public string JobTitle { get; set; }
        public int YearStarted { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            Worker[] workers = new Worker[5];

           
            for (int i = 0; i < workers.Length; i++)
            {
                Console.WriteLine($"Введіть дані для працівника {i + 1}:");
                Console.Write("  Прізвище: ");
                string lastName = Console.ReadLine();
                Console.Write("  Ініціали: ");
                string initials = Console.ReadLine();
                Console.Write("  Посада: ");
                string jobTitle = Console.ReadLine();

                int yearStarted;
                while (true)
                {
                    Console.Write("  Рік надходження на роботу: ");
                    try
                    {
                        yearStarted = int.Parse(Console.ReadLine());
                        break;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Помилка: введене значення має бути цілим числом.");
                    }
                }

                
                workers[i] = new Worker
                {
                    LastName = lastName,
                    Initials = initials,
                    JobTitle = jobTitle,
                    YearStarted = yearStarted
                };
            }
            workers = workers.OrderBy(x => x.LastName).ToArray();

        
            int searchYear;
            while (true)
            {
                Console.Write("Введіть стаж, який шукаєте: ");
                try
                {
                    searchYear = int.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Помилка: введене значення має бути цілим числом.");
                }
            }

           
            Console.WriteLine($"Прізвища працівників зі стажем більше {searchYear} років:");
            foreach (var worker in workers)
            {
                if (DateTime.Now.Year - worker.YearStarted > searchYear)
                {
                    Console.WriteLine(worker.LastName);
                }
            }

            Console.ReadLine();
        }
    }

}