using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            //Вывести на экран все элементы второй строки массива

            //int index1 = 10;
            //int index2 = 10;

            //int[,] arr = new int[index1, index2];

            //for (int i = 0; i < index1; i++)
            //{
            //    for (int j = 0; j < index2; j++)
            //    {
            //        arr[i, j] = new Random().Next(1, 11);
            //        Console.Write(arr[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine();
            //for (int j = 0; j < index2; j++)
            //{
            //    Console.Write($"{arr[1, j]} ");
            //}

            #endregion

            #region
            //С помощью генератора случайных значений создайте два массива. Выполните по отдельности сначала сложение, 
            //потом умножения массивов друг на друга. Выведете исходные массивы и результат вычислений на экран

            //Console.WriteLine("Исходные массивы:");
            //Console.WriteLine();

            //int index1 = 10;
            //int index2 = 10;

            //int[,] arr = new int[index1, index2];

            //for (int i = 0; i < index1; i++)
            //{
            //    for (int j = 0; j < index2; j++)
            //    {
            //        arr[i, j] = new Random().Next(1, 10);
            //        Console.Write(arr[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine();
            //int[,] arr2 = new int[index1, index2];

            //for (int i = 0; i < index1; i++)
            //{
            //    for (int j = 0; j < index2; j++)
            //    {
            //        arr2[i, j] = new Random().Next(1, 10);
            //        Console.Write(arr2[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine();
            //Console.WriteLine("Результат сложения:");
            //Console.WriteLine();

            //int[,] sum = new int[index1, index2];

            //for (int i = 0; i < index1; i++)
            //{
            //    for (int j = 0; j < index2; j++)
            //    {
            //        sum[i, j] = arr[i, j] + arr2[i, j];
            //        Console.Write(sum[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine();
            //Console.WriteLine("Результат умножения:");
            //Console.WriteLine();

            //int[,] multip = new int[index1, index2];

            //for (int i = 0; i < index1; i++)
            //{
            //    for (int j = 0; j < index2; j++)
            //    {
            //        multip[i, j] = arr[i, j] * arr2[i, j];
            //        Console.Write(multip[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region
            //Выясните есть ли одинаковые числа в массиве или же массив содержит только разные

            //int index1 = 5;
            //int index2 = 5;

            //bool a = false;

            //int[,] arr = new int[index1, index2];

            //for (int i = 0; i < index1; i++)
            //{
            //    for (int j = 0; j < index2; j++)
            //    {
            //        arr[i, j] = new Random().Next(1, 10);
            //        Console.Write(arr[i, j] + "\t");
            //        for (int k = 0; k < index1; k++)
            //        {
            //            for (int d = 0; d < index2; d++)
            //            {
            //                if (arr[i, j] == arr[k, d] && i != k && j != d)
            //                {
            //                    a = true;
            //                }
            //            }
            //        }
            //    }
            //    Console.WriteLine();
            //}
            //if (a == true)
            //{
            //    Console.WriteLine("Есть");
            //}
            //else if(a == false)
            //{
            //    Console.WriteLine("Нет");
            //}

            #endregion

            #region

            //Отсортируйте столбцы массива в порядке возрастания сумм их элементов

            //int[,] arr = new int[,] { { 3, 2, 4, 0, 4 }, { 1, 2, 4, 1, 5 }, { 3, 5, 2, 1, 1 }, { 1, 1, 1, 1, 1 }, { 5, 4, 9, 7, 3 } };

            //int index1 = 5;
            //int index2 = 5;

            //for (int n = 0; n < index1; n++)
            //{
            //    for (int j = 1; j < index2; j++)
            //    {
            //        int sumCur = 0;
            //        for (int i = 0; i < index1; i++)
            //        {
            //            sumCur += arr[i, j];
            //        }

            //        int sumPrev = 0;
            //        for (int i = 0; i < index1; i++)
            //        {
            //            sumPrev += arr[i, j - 1];
            //        }

            //        if (sumPrev > sumCur)
            //        {
            //            for (int k = 0; k < index2; k++)
            //            {
            //                int temp = arr[k, j];
            //                arr[k, j] = arr[k, j - 1];
            //                arr[k, j - 1] = temp;
            //            }
            //        }
            //    }
            //}
            //for (int i = 0; i < index1; i++)
            //{
            //    for (int j = 0; j < index2; j++)
            //    {
            //        Console.Write("{0}\t", arr[i, j]);
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region
            //Заполните главные диагонали массива нулями

            //сделал то же самое, только с единицами.
            //int index1 = 5;
            //int index2 = 5;

            //int[,] arr = new int[index1, index2];

            //int j = 4;

            //for (int i = 0; i < 5; i++)
            //{
            //    arr[i, i] = arr[i, j] = 1;
            //    j--;
            //}

            //for (int i = 0; i < index1; i++)
            //{
            //    for (int d = 0; d < index2; d++)
            //    {
            //        Console.Write($"{arr[i, d]} ");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region

            //Поменять максимальный и минимальный элемент массива местами
            int index1 = 3;
            int index2 = 3;

            int[,] arr = new int[index1, index2];

            int max = arr[0, 0];
            int min = arr[0, 0];

            for (int i = 0; i < index1; i++)
            {
                for (int j = 0; j < index2; j++)
                {
                    arr[i, j] = new Random().Next(0, 10);
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int i = 0; i < index1; i++)
            {
                for (int j = 0; j < index2; j++)
                {
                    if (min > arr[i, j])
                    {
                        min = arr[i, j];
                    }
                }
            }

            for (int i = 0; i < index1; i++)
            {
                for (int j = 0; j < index2; j++)
                {
                    if (max < arr[i, j])
                    {
                        max = arr[i, j];
                    }
                }
            }
            
            

            Console.WriteLine(max);
            Console.WriteLine(min);

            #endregion
        }
    }
}
