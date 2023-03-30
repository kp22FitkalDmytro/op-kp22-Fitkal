using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static string RemoveCommasAndDots(string input)
    {
        string result = input.Replace(",", "").Replace(".", "");
        return result;
    }
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
        string filePath = "input.txt";
        Dictionary<string, int> wordCounts = new Dictionary<string, int>();

        using (StreamReader reader = new StreamReader(filePath))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                // Removes all commas and dots from the line
                line = RemoveCommasAndDots(line);

                string[] words = MySplit(line, ' ');

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

        string outputFilePath = "output.txt";
        using (StreamWriter writer = new StreamWriter(outputFilePath))
        {
            foreach (KeyValuePair<string, int> pair in wordCounts)
            {
                // Removes all commas and dots from the word before writing it to the output file
                string word = RemoveCommasAndDots(pair.Key);
                writer.WriteLine($"{word} {pair.Value}");
            }
        }

        Console.WriteLine("Done!");
    }
}