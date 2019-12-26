using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 3-ех значное число");
            int num = int.Parse(Console.ReadLine());
            int b = num % 100 / 10;
            int a = num / 100;
            int c = num - a * 100 - b * 10;
            Console.WriteLine($"Число, при прочтении справа налево - {c}{b}{a}");
        }
    }
}
