using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            double days = 234;
            double weeks = Math.Floor(days / 7);
            Console.WriteLine($"Количетсво полных недель в 234 днях - {weeks}.");
        }
    }
}
