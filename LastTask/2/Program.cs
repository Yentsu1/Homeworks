using System;

namespace _2
{
    interface IPLayable
    {
        void Play()
        {

        }
        void Pause()
        {

        }
        void Stop()
        {

        }
    }
    interface IRecordable
    {
        void Record()
        {

        }
        void Pause()
        {

        }
        void Stop()
        {

        }
    }

    class Player : IPLayable, IRecordable
    {

    }

    class Program
    {
        static void Main(string[] args)
        {
            // 2. Создайте 2 интерфейса IPlayable и IRecodable. В каждом из интерфейсов создайте по 3 метода
            // void Play() / void Pause() / void Stop() и void Record() / void Pause() / void Stop() соответственно. 
            // Создайте производный класс Player от базовых интерфейсов IPlayable и IRecodable. 
            // Написать программу, которая выполняет проигрывание и запись. 

        }
    }
}
