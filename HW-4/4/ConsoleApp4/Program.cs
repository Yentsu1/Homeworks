using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Даны две переменные целого типа: A и B. Если их значения не равны, 
            //то присвоить каждой переменной сумму этих значений, 
            //а если равны, то присвоить переменным нулевые значения. Вывести новые значения переменных A и B. ​

            int a = new Random().Next(-10, 11);
            int b = new Random().Next(-10, 11);

            Console.WriteLine($"{a} {b}");

            if(a != b)
            {
                a = b = a + b;
                Console.WriteLine($"{a} {b}");
            }
            else
            {
                a = b = 0;
                Console.WriteLine($"{a} {b}");
            }
        }
    }
}
