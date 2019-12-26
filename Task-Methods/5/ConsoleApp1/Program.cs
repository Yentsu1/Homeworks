using System;

namespace ConsoleApp1
{
    class Program
    {
        //Спросить у пользователя сумму покупки, и узнать его скидку. Выдать результат – «К оплате с учетом скидки». 
        //В программе должно быть 2 метода, помимо Main(), Метод, который считает скидку и метод для отображения результата
        static void FinalPrice(double purch, double discount)
        {
            double discount2 = (100 - discount) / 100;
            double price = purch * discount2;
        }
        static void Output(double price)
        {
            Console.WriteLine($"Окончательная цена - {price}.");
        }
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Какая ваша сумма покупки?");
                double purch = double.Parse(Console.ReadLine());
                Console.WriteLine("Какая ваша скидка на покупку?");
                double discount = double.Parse(Console.ReadLine());
                double discount2 = (100 - discount) / 100;
                double price = purch * discount2;
                FinalPrice(purch, discount);
                Output(price);
            }
            catch
            {
                Console.WriteLine("Неверное значение.");
            }
        }
    }
}
