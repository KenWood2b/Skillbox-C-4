using System;

class Program
{
    static void Main(string[] args)
    {
        // Запрашиваем ввод строки от пользователя
        Console.WriteLine("Введите длинное предложение:");
        string input = Console.ReadLine();

        // Разделяем текст на слова и выводим их
        string[] words = SplitText(input);
        PrintWords(words);
    }

    // Метод для разделения текста на слова
    static string[] SplitText(string text)
    {
        return text.Split(' '); // Разделение строки по пробелу
    }

    // Метод для вывода каждого слова на новой строке
    static void PrintWords(string[] words)
    {
        foreach (string word in words)
        {
            Console.WriteLine(word);
        }
        Console.ReadKey();
    }
}
