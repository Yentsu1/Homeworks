using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //способ с временной переменной
            int a = 1;
            int b = 3;
            int c;
            c = a;
            a = b;
            b = c;
            Console.WriteLine(a);
            Console.WriteLine(b);
            //способ без временной переменной
            //int a = 1;
            //int b = 3;
            //a = a + b;
            //b = b - a;
            //b = -b;
            //a = a - b;
            //Console.WriteLine(a);
            //Console.WriteLine(b);

            //Способ с временной переменной менее затратный для компьютера,
            //т.к. выполняется меньше операций. Соответственно способ с временной переменной лучше.
        }
    }
}
