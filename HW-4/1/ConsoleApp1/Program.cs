using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Дано целое число.Если оно является положительным,
            //то прибавить к нему 1; если отрицательным, то вычесть из него 2;
            //если нулевым, то заменить его на 10.Вывести полученное число.​
            int rnd = new Random().Next(-10, 11);
            Console.WriteLine($"Первоначальное число - {rnd}.");
            if(rnd > 0)
            {
                ++rnd;
                Console.WriteLine(rnd);
            }
            else if(rnd < 0)
            {
                int rnd2 = rnd - 2;
                Console.WriteLine(rnd2);
            }
            else
            {
                rnd = 10;
                Console.WriteLine(rnd);
            }
        }
    }
}
