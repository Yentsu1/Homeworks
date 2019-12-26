using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ваше ФИО:");
            string fio = Console.ReadLine();
            Console.WriteLine("Введите ваш возраст:");
            string age = Console.ReadLine();
            Console.WriteLine("Какова ваша профессия:");
            string prof = Console.ReadLine();
            Console.WriteLine($"Здравствуйте, {fio}. Ваш возраст - {age} лет. Ваша профессия - {prof}");
        }
    }
}
