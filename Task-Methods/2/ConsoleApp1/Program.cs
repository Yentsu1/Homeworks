using System;

namespace ConsoleApp1
{
    class Program
    //2. Написать методы для перевод секунд в дни, часы, минуты.
    {
        static void days(double second, double secInDay)
        {
            double days = second / secInDay;
            Console.WriteLine($"Кол-во дней - {days}.");
        }
        static void hours(double second, double secInHour)
        {
            double hours = second / secInHour;
            Console.WriteLine($"Кол-во часов - {hours}.");
        }
        static void minutes(double second, double secInMinute)
        {
            double minutes = second / secInMinute;
            Console.WriteLine($"Кол-во минут - {minutes}.");
        }
        static void Main(string[] args)
        {
            double secInDay = 86400;
            double secInHour = 3600;
            double secInMinute = 60;
            try
            {
                Console.WriteLine("Введите кол-во секунд:");
                double second = double.Parse(Console.ReadLine());
                
                days(second, secInDay);
                hours(second, secInHour);
                minutes(second, secInMinute);
            }
            catch
            {
                Console.WriteLine("Неверные данные.");
            }
        }
    }
}
