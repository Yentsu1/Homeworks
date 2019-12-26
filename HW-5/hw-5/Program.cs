using System;

namespace hw_5
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            ////Найти сумму положительных нечетных чисел, меньших 50.​
            //int sum = 0;
            //for (int i = 1; i <= 50; i += 2)
            //{
            //    sum += i;
            //}
            //Console.WriteLine(sum);
            #endregion



            #region
            ////Найти сумму целых положительных чисел из промежутка от a до b, кратных четырем.​
            //int sum = 0;
            //for (int i = 0; i <= 100; i++)
            //{
            //    if (i % 4 == 0)
            //    {
            //        sum += i;
            //    }
            //}
            //Console.WriteLine(sum);
            #endregion



            #region
            //Найти: а) все двузначные числа, сумма квадратов цифр которых делится на 13;
            //б) все двузначные числа, обладающие следующим свойством: если к сумме цифр числа прибавить квадрат этой суммы, 
            //то получится снова искомое число.​

            //a:

            //for (int i = 10; i < 100; i++)
            //{
            //    double a = i % 10;
            //    double b = i / 10;
            //    double powA = Math.Pow(a, 2);
            //    double powB = Math.Pow(b, 2);
            //    double sum = powA + powB;

            //    if (sum % 13 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //b:

            //for (int i = 10; i < 100; i++)
            //{
            //    double a = i % 10;
            //    double b = i / 10;
            //    double sum = a + b;
            //    double powSum = Math.Pow(sum, 2);
            //    double res = sum + powSum;

            //    if (res == i)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            #endregion



            #region

            ////Даны два целых числа A и B(A < B).Найти сумму и произведение всех целых чисел от A до B включительно.​
            //int a = new Random().Next(1,6);
            //int b = new Random().Next(6,11);
            //int sum = 0;
            //int res = 1;
            //Console.WriteLine($"Диапазон - от {a} до {b} включительно.");

            //for (int i = a; i <= b; i++)
            //{
            //    sum += i;
            //    res *= i;
            //}
            //Console.WriteLine($"Сумма - {sum}.");
            //Console.WriteLine($"Произведение - {res}.");


            #endregion



            #region
            //Даны два целых числа A и B(A < B).Вывести в порядке возрастания все целые числа, 
            //расположенные между A и B(включая сами числа A и B),  а также количество N этих чисел.​

            //int a = new Random().Next(1, 6);
            //int b = new Random().Next(6, 11);

            //Console.WriteLine($"Диапазон - от {a} до {b} включительно.");
            //Console.WriteLine();
            //int n = 0;

            //for (int i = a; i <= b; i++)
            //{
            //    Console.WriteLine(i);
            //    n++;
            //}
            //Console.WriteLine();
            //Console.WriteLine($"Количество чисел - {n}.");
            #endregion



            #region

            //Дано вещественное число — цена 1 кг конфет. Вывести стоимость 1.2, 1.4, …, 2 кг конфет.​
            //double price = new Random().Next(1, 10);
            //Console.WriteLine($"Цена за 1 кг - {price}.");
            //double i = 1;

            //while (i<=2)
            //{
            //    double res = i * price; 
            //    Console.WriteLine($"Стоимость {i} кг конфет - {res}.");
            //    i += 0.2;
            //}

            #endregion



            #region
            //Даны целые положительные числа A и B (A < B). Вывести все целые числа от A до B включительно; 
            //при этом каждое число должно выводиться столько раз, каково его значение (например, число 3 выводится 3 раза).

            int a = new Random().Next(1, 6);
            int b = new Random().Next(6, 11);
            Console.WriteLine($"Диапазон - от {a} до {b} включительно.");
            for (int i = a; i <= b; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine();
            }

            #endregion
        }
    }
}
