using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            int b = int.Parse(Console.ReadLine());
            int average = (a + b) / 2;
            Console.WriteLine($"Среднее арифметическое 2-ух чисел - {average}.");
        }
    }
}
