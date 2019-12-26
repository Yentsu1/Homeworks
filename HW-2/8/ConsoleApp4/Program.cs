using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 2-у значное число:");
            int number = int.Parse(Console.ReadLine());
            int num2 = number % 10;
            int num1 = (number - num2) / 10;
            int am = num1 + num2;
            int comp = num1 * num2;
            Console.WriteLine($"Число десятков - {num1}. Число едениц - {num2}. Сумма цифр - {am}. Произведение цифр - {comp}.");
        }
    }
}
