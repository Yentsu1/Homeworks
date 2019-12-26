using System;

namespace ConsoleApp1
{
    abstract class AbstractHandler
    {
        public abstract void Open();
        public abstract void Create();
        public abstract void Change();
        public abstract void Save();
    }
    class XMLHandler : AbstractHandler
    {
        protected string text { get; set; }
        protected string nameOfFile { get; set; }
        public override void Change()
        {
            Console.WriteLine("You have entered editor.");
            Console.WriteLine($"Text of file: {text}.");
            Console.WriteLine("Write your edit:");
            text = Console.ReadLine();
            Console.WriteLine($"New text is: {text}.");
        }

        public override void Create()
        {
            Console.WriteLine("Choose your XML file's name:");
            nameOfFile = Console.ReadLine();
            Console.WriteLine($"You created new file which was named {nameOfFile}.");
        }

        public override void Open()
        {
            Console.WriteLine($"I have opened {nameOfFile} XML file.");
        }

        public override void Save()
        {
            Console.WriteLine($"I have saved {nameOfFile} XML file.");
        }
    }

    class TXTHandler : AbstractHandler
    {
        protected string text { get; set; }
        protected string nameOfFile { get; set; }
        public override void Change()
        {
            Console.WriteLine("You have entered editor.");
            Console.WriteLine($"Text of file: {text}.");
            Console.WriteLine("Write your edit:");
            text = Console.ReadLine();
            Console.WriteLine($"New text is: {text}.");
        }

        public override void Create()
        {
            Console.WriteLine("Choose your TXT file's name:");
            nameOfFile = Console.ReadLine();
            Console.WriteLine($"You created new file which was named {nameOfFile}.");
        }

        public override void Open()
        {
            Console.WriteLine($"I have opened {nameOfFile} TXT file.");
        }

        public override void Save()
        {
            Console.WriteLine($"I have saved {nameOfFile} TXT file.");
        }
    }

    class DOCHandler : AbstractHandler
    {
        protected string text { get; set; }
        protected string nameOfFile { get; set; }
        public override void Change()
        {
            Console.WriteLine("You have entered editor.");
            Console.WriteLine($"Text of file: {text}.");
            Console.WriteLine("Write your edit:");
            text = Console.ReadLine();
            Console.WriteLine($"New text is: {text}.");
        }

        public override void Create()
        {
            Console.WriteLine("Choose your DOC file's name:");
            nameOfFile = Console.ReadLine();
            Console.WriteLine($"You created new file which was named {nameOfFile}.");
        }

        public override void Open()
        {
            Console.WriteLine($"I have opened {nameOfFile} DOC file.");
        }

        public override void Save()
        {
            Console.WriteLine($"I have saved {nameOfFile} DOC file.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //1. Создайте класс AbstractHandler. 
            //В теле класса создать методы void Open(), void Create(), void Change(), void Save(). 
            //Создать производные классы XMLHandler, TXTHandler, DOCHandler от базового класса AbstractHandler. 
            //Написать программу, которая будет выполнять определение документа и для каждого формата должны быть методы 
            //открытия, создания, редактирования, сохранения определенного формата документа.

            Console.WriteLine("Choose type of file XML/TXT/DOC:");
            string file = Console.ReadLine();
            file = file.ToLower();
            if (file == "xml")
            {
                AbstractHandler abstractHandlerXML = new XMLHandler();
                Console.WriteLine("What do you want to do with file? open/create/change/save");
                string option = Console.ReadLine();
                option = option.ToLower();
                if (option == "open")
                {
                    abstractHandlerXML.Open();
                }
                else if (option == "create")
                {
                    abstractHandlerXML.Create();
                }
                else if (option == "change")
                {
                    abstractHandlerXML.Change();
                }
                else if (option == "save")
                {
                    abstractHandlerXML.Save();
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            else if (file == "txt")
            {
                AbstractHandler abstractHandlerTXT = new TXTHandler();
                Console.WriteLine("What do you want to do with file? open/create/change/save");
                string option = Console.ReadLine();
                option = option.ToLower();
                if (option == "open")
                {
                    abstractHandlerTXT.Open();
                }
                else if (option == "create")
                {
                    abstractHandlerTXT.Create();
                }
                else if (option == "change")
                {
                    abstractHandlerTXT.Change();
                }
                else if (option == "save")
                {
                    abstractHandlerTXT.Save();
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            else if (file == "doc")
            {
                AbstractHandler abstractHandlerDOC = new DOCHandler();
                Console.WriteLine("What do you want to do with file? open/create/change/save");
                string option = Console.ReadLine();
                option = option.ToLower();
                if (option == "open")
                {
                    abstractHandlerDOC.Open();
                }
                else if (option == "create")
                {
                    abstractHandlerDOC.Create();
                }
                else if (option == "change")
                {
                    abstractHandlerDOC.Change();
                }
                else if (option == "save")
                {
                    abstractHandlerDOC.Save();

                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            else
            {
                throw new NotImplementedException();
            }
        }
    }
}
