using System;

namespace ConsoleApp2
{
    class Program
    //Дана сторона квадрата. 
    //Найти его периметр. Метод должен быть универсальным (на вход может как целое число, так и вещественное, так и строка).
    {
        static void Method(double a)
        {
            double p = Math.Pow(a, 2);
            Console.WriteLine($"Перимерт квадрата - {p}.");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сторону квадрата:");
            try
            {
                double a = double.Parse(Console.ReadLine());
                Method(a);
            }
            catch
            {
                Console.WriteLine("Неверные данные.");
            }
        }
    }
}
