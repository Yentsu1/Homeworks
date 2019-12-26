using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
        Start:
            List<string> words = new List<string> { "кот", "собака", "попугай", "кролик", "хомяк", "черепаха", "рыбы" };

            int tries = 5;
            int rnd = new Random().Next(0, words.Count);
            string word = words[rnd];
            int length = word.Length;
            string under = new string('_', word.Length);

            Console.Clear();

            Console.WriteLine("Поиграем в игру в слова <да/нет>:");
            string gameStart = Console.ReadLine();
        
            if (gameStart == "да")
            {
                Console.Clear();
                Console.WriteLine("Угадайте мое секретное слово.");
                Console.WriteLine($"Оно содержит {length} букв(ы), и вы можете угадывать одну букву или сразу слово за раз.");
                Console.WriteLine($"Вам предоставляется {tries} неправильных угадываний. Тема - домашние животные.");
                while (word != under)
                {
                    string letter = string.Empty;
                    do
                    {
                        Console.WriteLine();
                        Console.WriteLine($"Ваше слово: {under}");
                        Console.WriteLine($"Количество попыток - {tries}");
                        Console.Write("Угадайте букву или всё слово сразу:");
                        
                        letter = Console.ReadLine();
                        if (letter.Length > 1)
                        {
                            if (letter == word)
                            {
                                goto win;
                            }
                            else
                            {
                                goto lose;
                            }
                        }
                    } while (letter.Length != 1);

                    if (word.Contains(letter))
                    {
                        Console.WriteLine("Правильно!");
                        var arr = under.ToCharArray();
                        for (int i = 0; i < word.Length; i++)
                        {
                            if (letter[0] == word[i])
                            {
                                arr[i] = letter[0];
                            }
                            under = new string(arr.ToArray());
                        }
                        if (under == word)
                        {
                            goto win;
                        }
                    }
                    else
                    {
                        tries--;
                        if (tries < 1)
                        {
                            goto lose;
                        }
                        else
                        {
                            Console.WriteLine("Неправильно!");
                            Console.WriteLine();
                        } 
                    }
                }
            win:
                Console.WriteLine("Угадано!");
                Console.WriteLine($"Вам было загадано слово {word}.");
                Console.WriteLine("Чтобы продолжить игру нажмите любую клавишу.");
                Console.ReadKey();
                goto Start;
            }
            else if (gameStart == "нет")
            {
                Console.WriteLine("Нажмите любую клавишу для закрытия программы.");
                Console.ReadKey();
                return;
            }
            else
            {
                Console.WriteLine("Я вас не понимаю.");
                Console.ReadKey();
                goto Start;
            }
        
        lose:
            Console.WriteLine();
            Console.WriteLine("Вы проиграли.");
            Console.WriteLine("Чтобы выйти нажмите любую клавишу.");
            Console.ReadKey();
        }
    }
}
