using System;

namespace Task10
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task-1
            // Составить программу обмена значениями трех переменных величин а, b, c строкового типа по следующей схеме: 
            // а) b присвоить значение c, а присвоить значение b, c присвоить значение а; 
            // б) b присвоить значение а, с присвоить значение b, а присвоить значение c​

            //string a = "str1";
            //string b = "str2";
            //string c = "str3";
            //string temp = string.Empty;

            // а:

            //temp = a;
            //a = b;
            //b = c;
            //c = temp;

            //Console.WriteLine($"a = {a}, b = {b}, c = {c}.");

            // б:

            //temp = c;
            //c = b;
            //b = a;
            //a = temp;

            //Console.WriteLine($"a = {a}, b = {b}, c = {c}.");

            #endregion

            #region Task-2
            //Дано слово. Верно ли, что оно начинается и оканчивается на одну и ту же букву?​

            //string word = "worw";

            //if (word[0] == word[word.Length - 1])
            //{
            //    Console.WriteLine("True");
            //}
            //else
            //{
            //    Console.WriteLine("False");
            //}

            #endregion

            #region Task-3
            //Даны два слова. Верно ли, что первое слово начинается на ту же букву, на которую заканчивается второе слово? ​

            //string word1 = "word";
            //string word2 = "drow";

            //if (word1[0] == word2[word2.Length - 1])
            //{
            //    Console.WriteLine("True");
            //}
            //else
            //{
            //    Console.WriteLine("False");
            //}

            #endregion

            #region Task-4
            //Дано предложение. Определить, сколько в нем одинаковых пар соседних букв.​

            //string sentence = "Дggано предложениеbb. Определить, скольccко в нем одинаковых пар соседних букв.​aa";
            //int count = 0;

            //for (int i = 0; i < sentence.Length - 1; i++)
            //{
            //    if (sentence[i] == sentence[i + 1])
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine(count);

            #endregion

            #region Task-5
            //Дан текст. Определить, сколько в нем предложений. ​

            //string text = "Предложение а. Предложение б. Предложение в.";
            //int count = 0;
            //char point = '.';

            //for (int i = 0; i < text.Length; i++)
            //{
            //    if (text[i] == point)
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine(count);

            #endregion

            #region Task-6
            //Дано предложение, в котором имеются одна буква С и одна буква Т. 
            //Определить, какая из них встречается раньше (при просмотре слова слева направо)​

            //string sentence = "qwerty C, asdfg T";  // буквы C и T на латиннице.
            //char c = 'C';
            //char t = 'T';

            //for (int i = 0; i < sentence.Length; i++)
            //{
            //    if (sentence[i] == c)
            //    {
            //        Console.WriteLine("Буква C встречается раньше.");
            //        break;
            //    }
            //    else if (sentence[i] == t)
            //    {
            //        Console.WriteLine("Буква T встречается раньше.");
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Этой буквы нет в предложении.");
            //    }
            //}

            #endregion

            #region Task-6
            //Дано предложение. Все его символы, стоящие на третьем, шестом, девятом и т. д. местах, заменить буквой а. ​

            //string sentence = "Просто предложение";
            //char a = 'а';

            //for (int i = 0; i < sentence.Length; i++)
            //{
            //    if ((i + 1) % 3 == 0)
            //    {
            //        sentence = sentence.Remove(i, 1).Insert(i, "а");
            //    }
            //}
            //Console.WriteLine(sentence);

            #endregion

            #region Task-7
            //Дано слово. Поменять местами его вторую и пятую буквы. ​

            //string word = "hello";

            //char temp1;
            //char[] temp = word.ToCharArray();
            //temp1 = temp[1];
            //temp[1] = temp[4];
            //temp[4] = temp1;
            //Console.WriteLine(String.Join("", temp));

            #endregion

            #region Task-8
            //Дан текст. Найти сумму всех имеющихся в нем чисел.​

            string text = "qwe1rtyasd5fg4ghj";
            int res = 0;

            foreach (char ch in text)
            {
                if (char.IsDigit(ch))
                {
                    res += int.Parse(ch.ToString());
                }
            }
            Console.WriteLine(res);

            #endregion
        }
    }
}
