using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Дано целое число в диапазоне 20–69, определяющее возраст(в годах). 
            //Вывести строку-описание указанного возраста, обеспечив правильное согласование числа со словом «год», например: 
            //20 — «двадцать лет», 32 — «тридцать два года», 41 — «сорок один год»
            int age = new Random().Next(20, 70);
            int tenth = age / 10;
            int years = age % 10;

            Console.WriteLine(age);

            switch (tenth)
            {
                case 2:
                    Console.Write("двадцать ");
                    break;
                case 3:
                    Console.Write("тридцать ");
                    break;
                case 4:
                    Console.Write("сорок ");
                    break;
                case 5:
                    Console.Write("пятьдесят ");
                    break;
                case 6:
                    Console.Write("шестьдесят ");
                    break;
            }
            switch (years)
            {
                case 1:
                    Console.Write("один ");
                    break;
                case 2:
                    Console.Write("два ");
                    break;
                case 3:
                    Console.Write("три ");
                    break;
                case 4:
                    Console.Write("четрые ");
                    break;
                case 5:
                    Console.Write("пять ");
                    break;
                case 6:
                    Console.Write("шесть ");
                    break;
                case 7:
                    Console.Write("семь ");
                    break;
                case 8:
                    Console.Write("восемь ");
                    break;
                case 9:
                    Console.Write("девять ");
                    break;
            }
            if (years >= 5 || years == 0)
            {
                Console.Write("лет.");
            }
            else if (years == 1)
            {
                Console.Write("год.");
            }
            else
            {
                Console.Write("года.");
            }
        }
    }
}
