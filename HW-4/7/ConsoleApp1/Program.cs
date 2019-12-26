using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Робот может перемещаться в четырех направлениях(«С» — север,  «З» — запад, «Ю» — юг, «В» — восток) и принимать три цифровые
            //команды: 0 — продолжать движение, 1 — поворот налево, –1 — поворот направо. 
            //Дан символ C — исходное направление робота и целое число N — посланная ему команда.Вывести направление робота после выполнения 
            //полученной команды.​
            Console.WriteLine("Введите символ направления(«С» — север, «З» — запад, «Ю» — юг, «В» — восток):");
            char C = char.Parse(Console.ReadLine());
            Console.WriteLine("Введите цифровую команду для робота (0 — продолжать движение, 1 — поворот налево, -1 — поворот направо): ");
            int N = int.Parse(Console.ReadLine());

            switch (N)
            {
                case 1:
                    switch (C)
                    {
                        case 'С':
                            Console.WriteLine("З");
                            break;
                        case 'Ю':
                            Console.WriteLine("В");
                            break;
                        case 'З':
                            Console.WriteLine("С");
                            break;
                        case 'В':
                            Console.WriteLine("Ю");
                            break;
                    }
                    break;
                case -1:
                    switch (C)
                    {
                        case 'С':
                            Console.WriteLine("В");
                            break;
                        case 'Ю':
                            Console.WriteLine("З");
                            break;
                        case 'З':
                            Console.WriteLine("С");
                            break;
                        case 'В':
                            Console.WriteLine("Ю");
                            break;
                    }
                    break;
                case 0:
                    switch (C)
                    {
                        case 'С':
                            Console.WriteLine("С");
                            break;
                        case 'Ю':
                            Console.WriteLine("Ю");
                            break;
                        case 'З':
                            Console.WriteLine("З");
                            break;
                        case 'В':
                            Console.WriteLine("В");
                            break;
                    }
                    break;
            }
        }
    }
}
