using System;
using StringExtensionLibrary;

namespace StringExtinsionApp
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string str = null;

            Console.Write("Введите строку для разбора: ");
            str = Console.ReadLine();
            Console.WriteLine("Количество слов в строке равно: {0}", str.CountWordsString());
            Console.WriteLine("Количество гласных букв в строке равно: {0}", str.CountVowelString());
            Console.WriteLine("Инвертированная строка: {0}", str.InvertString());
            Console.ReadLine();
        }
    }
}
