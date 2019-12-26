using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Даны три целых числа. Найти количество положительных и количество отрицательных чисел в исходном наборе. ​
            int a = new Random().Next(-10, 11);
            int b = new Random().Next(-10, 11);
            int c = new Random().Next(-10, 11);
            Console.WriteLine($"{a} {b} {c}");
            int pos = 0;
            int neg = 0;
            if (a > 0) pos++;
            if (a < 0) neg++;

            if (b > 0) pos++;
            if (b < 0) neg++;

            if (c > 0) pos++;
            if (c < 0) neg++;
            Console.WriteLine($"Количество положительных - {pos}. Количество отрицательных - {neg}.");
        }
    }
}
