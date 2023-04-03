using System;
using System.Text;

namespace Exercise_2
{
    //  class MyExceptionA : Exception
    // {
    //     public MyExceptionA(string message)
    //         : base(message)
    //     {
    //     }
    // }
    // internal class Program
    // {

    //     static void Main(string[] args)
    //     {
    //         List<Worker> workers= new List<Worker>();
    //         workers.Add(new Worker("Artem A", (Dolgnost)1, 1997));
    //         //workers.Add(new Worker("Grtem A", (Dolgnost)1, 1997));
    //         //workers.Add(new Worker("Srtem A", (Dolgnost)1, 1997));
    //         //workers.Add(new Worker("ArteR A", (Dolgnost)1, 1997));
    //         //workers.Add(new Worker("Brtem A", (Dolgnost)1, 1997));
    //         //workers.Sort((x,y)=> string.Compare(x.FIO,y.FIO));
    //         //foreach (var item in workers)
    //         //{
    //         //    Console.WriteLine(item.FIO + "  " + item.MyDolgnost.ToString() + " " + item.AllAge) ;
    //         //}
    //         //workers[0].AddAge();
    //         //foreach(Worker worker in workers)
    //         //{
    //         //    Console.WriteLine(worker);
    //         //}
    //         workers[0].AgeExp();
    //         Console.ReadKey();
    //     }
    // }
    //public struct Worker
    // {
    //     public string FIO { get; set; }
    //     public Dolgnost MyDolgnost { get; set; }
    //     public int AllAge { get; set; }
    //     public int AllAgeEXP { get; set; }
    //     public Worker(string FIO, Dolgnost dolgnost, int age)
    //     {
    //         this.FIO = FIO;
    //         MyDolgnost = dolgnost;
    //         AllAge = age;
    //     }
    //     public void AddName()
    //     {
    //         while (true)
    //         {
    //             Console.WriteLine("InputName : ");

    //             this.FIO = (Console.ReadLine());

    //             try
    //             {
    //                 if(FIO.Length < 5)
    //                 {
    //                     throw new Exception();

    //                 }
    //                 break;

    //             }
    //             catch (Exception e)
    //             {
    //                 Console.WriteLine("FIO menshe 5");
    //                 Thread.Sleep(1000);
    //             }
    //             Console.Clear();
    //         }
    //     }
    //     public void AddDolgnost()
    //     {
    //         while (true)
    //         {
    //             Console.WriteLine("Rabochi - 1 ");
    //             Console.WriteLine("Meneger - 2 ");
    //             Console.WriteLine("Director - 3 ");
    //             Console.WriteLine("InputDolgnost : ");

    //             //MyDolgnost = (Dolgnost) Convert.ToInt32(Console.ReadLine());

    //             try
    //             {

    //                 MyDolgnost = (Dolgnost)Convert.ToInt32(Console.ReadLine());
    //                 if ((int)MyDolgnost > 3)
    //                 {
    //                     throw new IndexOutOfRangeException();
    //                 }
    //                 else
    //                 {
    //                     break;
    //                 }



    //             }
    //             catch (IndexOutOfRangeException d)
    //             {
    //                 Console.WriteLine("FIO menshe 5");
    //                 Thread.Sleep(1000);

    //             }catch(Exception e)
    //             {
    //                 Console.WriteLine("text");
    //                 Thread.Sleep(1000);
    //             }


    //             Console.Clear();
    //         }
    //     }
    //     public void AddAge()
    //     {
    //         while (true)
    //         {
    //             Console.WriteLine("Input Age");
    //             try
    //             {
    //                 AllAge = Convert.ToInt32(Console.ReadLine());
    //                 break;
    //             }

    //             catch (Exception e)
    //             {
    //                 Console.WriteLine("text");
    //                 Thread.Sleep(1000); 

    //             }
    //             Console.Clear();
    //         }
    //     }
    //     public void AgeExp()
    //     {
    //         int data = DateTime.Now.Date.Year;
    //         while (true)
    //         {

    //             Console.WriteLine("Input AgeExp");
    //             try
    //             {

    //                 AllAgeEXP = Convert.ToInt32(Console.ReadLine());
    //                 if (data - AllAge < AllAgeEXP)
    //                 {
    //                     throw new MyExceptionA("Not privus");
    //                 }
    //             }
    //             catch (MyExceptionA e)
    //             {
    //                 Console.WriteLine(e.Message);
    //                 Thread.Sleep(1000);
    //             }
    //             catch (Exception e)
    //             {
    //                 Console.WriteLine("text");
    //                 Thread.Sleep(1000);

    //             }

    //             Console.Clear();
    //         }
    //     }
    // }
    //public enum Dolgnost
    // {
    //     Rabochi = 1,
    //     Meneger = 2,
    //     Director= 3

    // }
    class Worker
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
            Console.OutputEncoding = Encoding.UTF8;
            // Створюємо масив з п'яти працівників
            Worker[] workers = new Worker[5];

            // Вводимо дані для кожного працівника
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

                // Додаємо нового працівника до масиву
                workers[i] = new Worker
                {
                    LastName = lastName,
                    Initials = initials,
                    JobTitle = jobTitle,
                    YearStarted = yearStarted
                };
            }

            // Вводимо значення стажу, яке використовуватимемо для пошуку
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

            // Виводимо на екран прізвища працівників, стаж яких перевищує введене значення
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