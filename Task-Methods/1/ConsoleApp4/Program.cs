using System;

namespace ConsoleApp4
{
    class Program
    //1.Напишите программу и три метода в ней, которые переводят гривны в $, €, российские рубли
    {
        static void Dollar(double money, double dol)
        {
            double change = money * dol;
            Console.WriteLine($"Кол-во денег в долларах - {change}.");
        }
        static void Euro(double money, double eu)
        {
            double change = money * eu;
            Console.WriteLine($"Кол-во денег в евро - {change}.");
        }
        static void Rub(double money, double rub)
        {
            double change = money * rub;
            Console.WriteLine($"Кол-во денег в рублях - {change}.");
        }
        static void Main(string[] args)
        {
            double money;
            Console.WriteLine("Введите кол-во денег (в гривнах):");
            money = double.Parse(Console.ReadLine());
            double dol = 0.041;
            double eu = 0.037;
            double rub = 2.61;
            Dollar(money, dol);
            Euro(money, eu);
            Rub(money, rub);
        }
    }
}
