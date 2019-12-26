using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Единицы длины пронумерованы следующим образом: 1 — дециметр,  2 — километр, 3 — метр, 4 — миллиметр, 5 — сантиметр.
            //Дан номер единицы длины(целое число в диапазоне 1–5) и длина отрезка в этих единицах(вещественное число). 
            //Найти длину отрезка в метрах. ​
            int a = new Random().Next(1, 6); //единицы измерения
            int b = new Random().Next(1, 6); //длинна отрезка
            Console.WriteLine($"{a} {b}");

            if (a == 1)
            {
                double length1 = b / 10.0;
                Console.WriteLine($"Длинна отрезка - {length1} м.");
            }
            else if (a == 2)
            {
                int length2 = b * 1000;
                Console.WriteLine($"Длинна отрезка - {length2} м.");
            }
            else if (a == 3)
            {
                int length3 = b;
                Console.WriteLine($"Длинна отрезка - {length3} м.");
            }
            else if (a == 4)
            {
                double length4 = b / 1000.0;
                Console.WriteLine($"Длинна отрезка - {length4} м.");
            }
            else if (a == 5)
            {
                double length5 = b / 100.0;
                Console.WriteLine($"Длинна отрезка - {length5} м.");
            }
        }
    }
}
