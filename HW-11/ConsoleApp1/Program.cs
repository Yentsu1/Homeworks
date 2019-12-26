#region Task-1
//using System;
//using System.Collections;
//using System.Collections.Generic;

//namespace ConsoleApp1
//{

//    class Worker
//    {
//        public string name { get; set; }
//        public string position { get; set; }
//        public int year { get; set; }

//        public static void AllWorkers()
//        {
//            List<Worker> workers = new List<Worker>();

//            workers.Add(new Worker() { name = "Олегов Олег Олегович", position = "Директор", year = 2003 });
//            workers.Add(new Worker() { name = "Александров Александр Александрович", position = "Менеджер", year = 2014 });
//            workers.Add(new Worker() { name = "Платонов Платон Платонович", position = "Бухгалтер", year = 2012 });

//            Console.WriteLine("Введите год:");
//            int userYear = int.Parse(Console.ReadLine());

//            for (int i = 0; i < workers.Count; i++)
//            {
//                if (workers[i].year > userYear)
//                {
//                    Console.WriteLine($"{workers[i].name}, {workers[i].position}, {workers[i].year}.");
//                }
//            }

//        }
//        public static void Sort()
//        {
//            List<string> name = new List<string>();

//            name.Add("Олегов Олег Олегович");
//            name.Add("Александров Александр Александрович");
//            name.Add("Платонов Платон Платонович");

//            name.Sort();

//            foreach (string str in name)
//            {
//                Console.WriteLine(str);
//            }
//        }
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            //        2.Определить класс с именем Worker, содержащий следующие поля:
//            //-фамилия и инициалы работника;
//            //-название занимаемой должности;
//            //-год поступления на работу.
//            //       Методы:
//            //-ввод данных в массив из n элементов в типа Worker;
//            //-упорядочить по алфавиту фамилии работников;
//            //-вывод работников, чей стаж работы в фирме превышает значение, введенное пользователем.

//            Console.WriteLine("Сортировка работников по фамилии:");
//            Worker.Sort();
//            Console.WriteLine();
//            Worker.AllWorkers();
//        }
//    }
//}
#endregion

#region Task-2
//using System;
//using System.Collections.Generic;

//namespace ConsoleApp1
//{
//    class Price
//    {
//        public string nameOfProduct { get; set; }
//        public string nameOfStore { get; set; }
//        public int cost { get; set; }

//        public static void AllProducts()
//        {
//            List<Price> product = new List<Price>();

//            product.Add(new Price() { nameOfProduct = "конфеты", nameOfStore = "АТБ", cost = 30 });
//            product.Add(new Price() { nameOfProduct = "печенье", nameOfStore = "Сильпо", cost = 40 });
//            product.Add(new Price() { nameOfProduct = "молоко", nameOfStore = "Варус", cost = 50 });

//            Console.WriteLine("Введите название товара (конфеты / молоко / печенье).");
//            string userProduct = Console.ReadLine();

//            for (int i = 0; i < product.Count; i++)
//            {
//                if (product[i].nameOfProduct == userProduct)
//                {
//                    Console.WriteLine($"{product[i].nameOfProduct}, {product[i].nameOfStore}, цена: {product[i].cost}.");
//                }
//            }

//        }
//        public static void Sort()
//        {
//            List<string> names = new List<string>();

//            names.Add("Конфеты");
//            names.Add("Печенье");
//            names.Add("Молоко");

//            names.Sort();

//            foreach (string str in names)
//            {
//                Console.WriteLine(str);
//            }
//        }
//    }
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            //Определить класс с именем Price, содержащий следующие поля:
//            //        -название товара;
//            //        -название магазина, в котором продается товар;
//            //        -стоимость товара в грн.
//            //       Методы:
//            //-ввод данных в массив из n элементов в типа Price;
//            //        -упорядочить в алфавитном порядке по названиям товаров;
//            //        -вывод информации о товаре, название которого ввел пользователь.

//            Price.Sort();
//            Console.WriteLine();
//            Price.AllProducts();

//        }
//    }
//}
#endregion

#region Task-3

//using System;
//using System.Collections.Generic;

//namespace ConsoleApp1
//{
//    class Rectangle
//    {
//        public double side1 { get; set; }

//        public double side2 { get; set; }

//        public Rectangle(double side1, double side2)
//        {
//            this.side1 = side1;
//            this.side2 = side2;
//        }

//        public double PerimeterCalculator()
//        {
//            return 2 * (side1 + side2);
//        }

//        public double AreaCalculator()
//        {
//            return side1 * side2;
//        }

//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {

//            //Создать класс с именем Rectangle, содержащий следующие поля:
//            //-два поля, описывающие длины сторон double side1, side2.
//            // -создать пользовательский конструктор Rectangle(double side1, double side2), 
//            // в теле которого поля side1 и side2 инициализируются значениями аргументов
//            // Методы
//            // - вычисление площади прямоугольника -double AreaCalculator()
//            //- периметр прямоугольника - double PerimeterCalculator()
//            //- Создать два свойства double Area и double Perimeter с одним методом доступа get
//            //- Написать программу, которая принимает от пользователя длины двух сторон прямоугольника и
//            // выводит на экран периметр и площадь.

//            Console.WriteLine("Введите первую сторону:");
//            double side1 = double.Parse(Console.ReadLine());

//            Console.WriteLine("Введите вторую сторону:");
//            double side2 = double.Parse(Console.ReadLine());

//            Rectangle rectangle = new Rectangle(side1, side2);

//            Console.Write("Площадь прямоугольника:");
//            Console.WriteLine(rectangle.AreaCalculator());

//            Console.Write("Периметр прямоугольника:");
//            Console.WriteLine(rectangle.PerimeterCalculator());

//        }
//    }
//}

#endregion