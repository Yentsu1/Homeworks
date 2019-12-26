using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длинну в сантиметрах:");
            double cm = int.Parse(Console.ReadLine());
            double m = Math.Floor(cm / 100);
            Console.WriteLine($"Число полных метров в нём - {m}");
        }
    }
}
