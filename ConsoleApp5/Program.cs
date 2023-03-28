using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    public static string[] MySplit(string input, char separator)
    {
        List<string> result = new List<string>();
        int start = 0;
        int end = 0;

        while (end < input.Length)
        {
            if (input[end] == separator)
            {
                // Додає підрядок між початковими та кінцевими індексами в списку
                result.Add(input.Substring(start, end - start));
                start = end + 1;
            }
            end++;
        }

        // додає останній індекс в список
        result.Add(input.Substring(start));

        return result.ToArray();
    }
    static void Main(string[] args)
    {
        string filePath = "input.txt"; // путь до файліка
        Dictionary<string, int> wordCounts = new Dictionary<string, int>();

        // читає текст
        using (StreamReader reader = new StreamReader(filePath))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                // розділяє слова по лініях
                string[] words =MySplit(line,' ');

                // дивиться на точність слів
                foreach (string word in words)
                {
                    if (wordCounts.ContainsKey(word))
                    {
                        wordCounts[word]++;
                    }
                    else
                    {
                        wordCounts[word] = 1;
                    }
                }
            }
        }

        // виписує слова з числом в новий файлік
        string outputFilePath = "output.txt";
        using (StreamWriter writer = new StreamWriter(outputFilePath))
        {
            foreach (KeyValuePair<string, int> pair in wordCounts)
            {
                writer.WriteLine($"{pair.Key} {pair.Value}");
            }
        }

        Console.WriteLine("Done!");
    }
}