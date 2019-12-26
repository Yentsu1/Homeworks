using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Ваше имя пользователя - {Environment.UserName}.");
            Console.WriteLine($"Версия операционной системы - {Environment.OSVersion}");
            Console.WriteLine($"Директория к системе Windows - {Environment.SystemDirectory}");
            Console.WriteLine($"Ваша система 64 битная? - {Environment.Is64BitOperatingSystem}");
            Console.WriteLine($"Имя в NetBIOS - {Environment.MachineName}");
        }
    }
}
