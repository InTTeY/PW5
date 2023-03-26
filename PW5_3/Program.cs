using System;

namespace PW5_3
{
    interface IFilter
    {
        string Execute(string textLine);
    }
    class DigitFilter : IFilter
    {
        public string Execute(string textLine)
        {
            return new string(textLine.Where(c => !char.IsDigit(c)).ToArray());
        }
    }
    class LetterFilter : IFilter
    {
        public string Execute(string textLine)
        {
            return new string(textLine.Where(c => !char.IsLetter(c)).ToArray());
        }
    }
    class program
    {
        static void Main()
        {
            Console.Write("Введите текст: ");
            string textLine = Console.ReadLine();

            Console.WriteLine("Выберите режим работы:");
            Console.WriteLine("digit - DigitFilter (удаление цифр)");
            Console.WriteLine("letter - LetterFilter (удаление букв)");
            string choice = Console.ReadLine();

            IFilter digitFilter = new DigitFilter();
            IFilter letterFilter = new LetterFilter();

            if (choice == "digit")
            {
                string digitsOnly = digitFilter.Execute(textLine);
                Console.WriteLine("Строка без цифр: " + digitsOnly);
            }
            else
            {
                if (choice == "letter")
                {
                    string lettersOnly = letterFilter.Execute(textLine);
                    Console.WriteLine("Строка без букв: " + lettersOnly);
                }
                else
                {
                    Console.WriteLine("!!!Не выбрано действие!!!");
                }
            }
        }
    }
}