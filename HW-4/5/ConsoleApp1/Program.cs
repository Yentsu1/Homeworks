using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишите программу, проверяющую число на четность.​
            int a = new Random().Next(-10, 11);
            int b = a % 2;
            Console.WriteLine($"{a}");
            if (b == 0)
            {
                Console.WriteLine($"{a} - чётное число.");
            }
            else
            {
                Console.WriteLine($"{a} - нечётное число.");
            }
        }
    }
}
