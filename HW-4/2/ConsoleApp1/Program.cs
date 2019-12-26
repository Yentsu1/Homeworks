using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Даны три целых числа. Найти количество положительных чисел в исходном наборе​
            int a = new Random().Next(-10, 11);
            int b = new Random().Next(-10, 11);
            int c = new Random().Next(-10, 11);
            Console.WriteLine($"Числа: {a} {b} {c}");
            if (a > 0 && b > 0 && c > 0)
            {
                Console.WriteLine($"Положительных чисел - 3");
            }
            else if ((a > 0 && b > 0) || (a > 0 && c > 0) || (b > 0 && c > 0))
            {
                Console.WriteLine($"Положительных чисел - 2");
            }
            else if (a > 0 || b > 0 || c > 0)
            {
                Console.WriteLine($"Положительных чисел - 1");
            }
            else
            {
                Console.WriteLine($"Положительных чисел - 0");
            }
        }
    }
}
