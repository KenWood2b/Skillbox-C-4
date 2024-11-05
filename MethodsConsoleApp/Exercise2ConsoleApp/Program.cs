using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Запрашиваем ввод строки от пользователя
            Console.WriteLine("Введите длинное предложение:");
            string input = Console.ReadLine();

            // Обратная перестановка слов и вывод результата
            string reversedSentence = ReverseWords(input);
            Console.WriteLine("\nПредложение с обратным порядком слов:");

            // Разделение перевернутого предложения на слова и вывод каждого слова на новой строке
            string[] words = SplitText(reversedSentence);
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
            Console.ReadKey();
        }

        // Метод для разделения текста на слова
        static string[] SplitText(string text)
        {
            return text.Split(' '); // Разделение строки по пробелу
        }

        // Метод для перестановки слов в обратном порядке
        static string ReverseWords(string inputPhrase)
        {
            // Разделяем предложение на слова
            string[] words = SplitText(inputPhrase);

            // Объединяем слова в обратном порядке
            string reversedSentence = "";
            for (int i = words.Length - 1; i >= 0; i--)
            {
                reversedSentence += words[i];
                if (i > 0) reversedSentence += " "; // Добавляем пробел, кроме последнего слова
            }

            return reversedSentence;
        }
    }
}
