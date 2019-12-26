using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ваше количество полных лет:");
            byte age;
            age = byte.Parse(Console.ReadLine());

            double ageMerc = age / 0.2408467;
            Console.WriteLine(("Возраст на Меркурии - ") + ageMerc);

            double ageVen = age / 0.61519726;
            Console.WriteLine(("Возраст на Венере - ") + ageVen);

            double ageMars = age / 1.8808158;
            Console.WriteLine(("Возраст на Марсе - ") + ageMars);

            double ageJup = age / 11.862615;
            Console.WriteLine(("Возраст на Юпитере - ") + ageJup);

            double ageSat = age / 29.447498;
            Console.WriteLine(("Возраст на Сатурне - ") + ageSat);

            double ageUran = age / 84.016846;
            Console.WriteLine(("Возраст на Уране - ") + ageUran);

            double ageNept = age / 164.79132;
            Console.WriteLine(("Возраст на Нептуне - ") + ageNept);
        }
    }
}
