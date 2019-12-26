using System;

namespace ConsoleApp4
{
    class Program
    //Дан радиус окружности. Найти ее диаметр. 
    //Метод должен быть универсальным (на вход может как целое число, так и вещественное, так и строка)
    {
        static void Diam(double r)
        {
            double d = 2 * r;
            Console.WriteLine($"Диаметр окружности - {d}.");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус окружности:");
            try
            {
                double r = double.Parse(Console.ReadLine());
                Diam(r);
            }
            catch
            {
                Console.WriteLine("Неверное значение.");
            }
        }
    }
}
