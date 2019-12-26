using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            double a = double.Parse(Console.ReadLine());
            double res = Math.Pow(a, 2);
            Console.WriteLine($"Квадрат данного числа - {res}.");
        }
    }
}
