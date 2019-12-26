using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 543;
            double b = 130;
            double sRect = a * b;

            double c = 130;
            double sSquare = c * c;

            double res = Math.Floor(sRect / sSquare);

            Console.WriteLine($"Ответ задания - {res} квадрата.");
        }
    }
}
