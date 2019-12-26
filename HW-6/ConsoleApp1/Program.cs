using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            // Заполнить массив из десяти элементов значениями, вводимыми с клавиатуры в ходе выполнения программы.

            //int[] arr = new int[10];

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine("Введите число:");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}
            #endregion

            #region
            // Заполнить массив из пятнадцати элементов случайным образом:
            // а) вещественными значениями, лежащими в диапазоне от 0 до 1;б) вещественными значениями х (22 х < 23);
            // в) вещественными значениями х (0 х < 10);г) вещественными значениями х (–50 х < 50);
            // д) целыми значениями, лежащими в диапазоне от 0 до 10 включительно.

            // а:

            //double[] arr = new double[15];
            //Random rnd = new Random();

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = rnd.NextDouble();
            //    Console.WriteLine(arr[i]);
            //}

            // б:

            //double[] arr = new double[15];
            //Random rnd = new Random();
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = rnd.Next(22, 23) + rnd.NextDouble();
            //    Console.WriteLine(arr[i]);
            //}

            // в:

            //double[] arr = new double[15];
            //Random rnd = new Random();
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = rnd.Next(0, 10) + rnd.NextDouble();
            //    Console.WriteLine(arr[i]);
            //}

            // г:

            //double[] arr = new double[15];
            //Random rnd = new Random();
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = rnd.Next(-50, 50) + rnd.NextDouble();
            //    Console.WriteLine(arr[i]);
            //}

            // д:

            //double[] arr = new double[15];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = new Random().Next(0, 11);
            //    Console.WriteLine(arr[i]);
            //}


            #endregion

            #region
            //Используя датчик случайных чисел, заполнить массив из двадцати элементов неповторяющимися числами.

            //List<int> nums = new List<int>();
            //int number;
            //Random rnd = new Random();

            //for (int i = 0; i < 21; i++)
            //{
            //    do
            //    {
            //        number = rnd.Next(1, 51);
            //    } while (nums.Contains(number));
            //    nums.Add(number);
            //    Console.WriteLine(nums[i]);
            //}
            #endregion

            #region
            //Дан массив. Все его элементы:а) увеличить в 2 раза;б) уменьшить на число А;в) разделить на первый элемент.

            // а:

            //int[] arr = new int[5] { 1, 2, 3, 4, 5 }; //первоначальный массив

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] *= 2;
            //    Console.WriteLine(arr[i]);
            //}

            // б:

            //int[] arr = new int[5] { 1, 2, 3, 4, 5 };
            //int A = new Random().Next(0, 5);
            //Console.WriteLine($"число, на которое надо уменьшить - {A}");
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] -= A;
            //    Console.WriteLine(arr[i]);
            //}

            // в:

            //double[] arr = new double[5] { 5, 2, 3, 4, 5 };

            //for (int i = 1; i < arr.Length; i++)
            //{
            //    arr[i] /= arr[0];
            //    Console.WriteLine(arr[i]);
            //}

            #endregion

            #region
            //В массиве хранятся сведения о стоимости 12 различных предметов. Определить общую стоимость всех предметов.
            //int[] arr = new int[12];
            //int sum = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    int rnd = new Random().Next(1, 21);
            //    arr[i] = rnd;
            //    Console.WriteLine(arr[i]);
            //    sum += arr[i];
            //}
            //Console.WriteLine();
            //Console.WriteLine($"Стоимость предметов - {sum}");
            #endregion

            #region
            //Дан массив целых чисел. Выяснить:а) верно ли, что сумма элементов массива есть четное число;
            //б) верно ли, что сумма квадратов элементов массива есть пятизначное число.

            // а:

            //int[] arr = new int[10];
            //int sum = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    int rnd = new Random().Next(1, 101);
            //    arr[i] = rnd;
            //    Console.WriteLine(arr[i]);
            //    sum += arr[i];
            //}
            //Console.WriteLine();
            //if (sum % 2 == 0)
            //{
            //    Console.WriteLine("True");
            //}
            //else
            //{
            //    Console.WriteLine("False");
            //}

            // б:

            //int[] arr = new int[10];
            //int sum = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    int rnd = new Random().Next(1, 61);
            //    arr[i] = rnd;
            //    sum += arr[i] * arr[i];
            //}
            //Console.WriteLine(sum);
            //Console.WriteLine();
            //if (sum >= 10000)
            //{
            //    Console.WriteLine("True");
            //}
            //else
            //{
            //    Console.WriteLine("False");
            //}

            #endregion

            #region
            //Дан массив. Напечатать: а) все неотрицательные элементы; б) все элементы, не превышающие число 100.

            // а:

            //int[] arr = new int[5];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    int rnd = new Random().Next(-200, 200);
            //    arr[i] = rnd;
            //    if (arr[i] > 0)
            //    {
            //        Console.Write($"{arr[i]}, ");
            //    }
            //}

            // б:

            //int[] arr = new int[5];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    int rnd = new Random().Next(-200, 200);
            //    arr[i] = rnd;
            //    if (arr[i] < 100)
            //    {
            //        Console.Write($"{arr[i]}, ");
            //    }
            //}

            #endregion

            #region

            //Дан массив целых чисел. Напечатать: а) все четные элементы; б) все элементы, оканчивающиеся нулем.

            // а:

            //int[] arr = new int[5];

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    int rnd = new Random().Next(-200, 200);
            //    arr[i] = rnd;
            //    if (arr[i] % 2 == 0)
            //    {
            //        Console.Write($"{arr[i]}, ");
            //    }
            //}

            // б:

            //int[] arr = new int[5];

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    int rnd = new Random().Next(-200, 200);
            //    arr[i] = rnd;
            //    if (arr[i] % 10 == 0)
            //    {
            //        Console.Write($"{arr[i]}, ");
            //    }
            //}

            #endregion

            #region

            //Дан массив. Вывести на экран сначала его неотрицательные элементы, затем отрицательные.

            //int[] arr = new int[5] { -3, -6, 2, 3, 7};

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] > 0)
            //    {
            //        Console.WriteLine(arr[i]);
            //    }
            //}

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] < 0)
            //    {
            //        Console.WriteLine(arr[i]);
            //    }
            //}

            #endregion

            #region
            //Дан массив. Вывести на экран сначала его элементы, стоящие на четных местах, затем — на нечетных.

            //int[] arr = new int[5] { 3, 2, 6, 1, 5 };

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (i % 2 != 0)
            //    {
            //        Console.WriteLine(arr[i]);
            //    }
            //}

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(arr[i]);
            //    }
            //}

            #endregion

            #region
            //Дан массив. Найти:а) сумму элементов массива, значение которых не превышает 20;
            //б) сумму элементов массива, больших числа a.

            //int[] arr = new int[5] {2, 15, 40, 60, 19 };
            //int sum = 0;
            //int sum2 = 0;

            //for (int i = 0; i < arr.Length; i++) //а
            //{
            //    if (arr[i] < 20)
            //    {
            //        sum += arr[i];
            //    }
            //}
            //Console.WriteLine($"Сумма равна {sum}");
            //Console.WriteLine();
            //int a = new Random().Next(10, 31);
            //Console.WriteLine($"Число a = {a}.");
            //for (int i = 0; i < arr.Length; i++) //б
            //{
            //    if (arr[i] > a)
            //    {
            //        sum2 += arr[i];
            //    }
            //}
            //Console.WriteLine($"Сумма равна {sum2}");

            #endregion

            #region
            //Дан массив целых чисел. Найти: а) сумму нечетных элементов; 
            //б) сумму элементов, кратных заданному числу; 
            //в) сумму элементов массива, кратных a или b.

            // а:

            //int[] arr = new int[5] { 2, 6, 10, 23, 7 };

            //int sum = 0;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] % 2 != 0)
            //    {
            //        sum += arr[i];
            //    }
            //}
            //Console.WriteLine(sum);

            // б:

            //int[] arr = new int[5] { 2, 6, 10, 23, 7 };

            //int sum = 0;
            //int n = new Random().Next(1,4);
            //Console.WriteLine($"Заданное число - {n}.");

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] % n == 0)
            //    {
            //        sum += arr[i];
            //    }
            //}
            //Console.WriteLine(sum);

            // в:

            //int[] arr = new int[5] { 2, 6, 10, 23, 7 };

            //int sum = 0;
            //int a = new Random().Next(1, 4);
            //int b = new Random().Next(1, 4);

            //Console.WriteLine($"Заданные числа - {a}, {b}.");

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] % a == 0 || arr[i] % b == 0)
            //    {
            //        sum += arr[i];
            //    }
            //}
            //Console.WriteLine(sum);

            #endregion

            #region
            //Определить сумму второго, четвертого, шестого и т.д.элементов массива.

            //int[] arr = new int[10];
            //int sum = 0;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    int rnd = new Random().Next(0, 11);
            //    arr[i] = rnd;
            //    Console.WriteLine(arr[i]); //элементы массива

            //    if (i % 2 != 0)
            //    {
            //        sum += arr[i];
            //    }
            //}
            //Console.WriteLine();
            //Console.WriteLine(sum);

            #endregion

            #region
            //Дан массив. Определить количество неотрицательных элементов.

            //int[] arr = new int[5];
            //int count = 0;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    int rnd = new Random().Next(-10, 11);
            //    arr[i] = rnd;
            //    Console.WriteLine(arr[i]);
            //    if (arr[i] > 0)
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine();
            //Console.WriteLine($"Количество неотрицательных элементов - {count}.");

            #endregion

            #region
            //Рост каждого из 22 учеников класса представлен в виде массива.
            //Определить количество учеников, рост которых не превышает значения r.

            //int[] arr = new int[22];
            //int r = new Random().Next(160,191);
            //int count = 0;
            //Console.WriteLine($"Значение r = {r}.");

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    int rnd = new Random().Next(160, 191);
            //    arr[i] = rnd;
            //    Console.Write($"{arr[i]}, ");
            //    if (arr[i] < r)
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine();
            //Console.WriteLine(count);

            #endregion
        }
    }
}
