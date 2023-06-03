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
    static void Main()
    {
        // читає файлік 
        string[] lines = File.ReadAllLines("students.txt");

        // дивиться чи є оцінка менша 60
        foreach (string line in lines)
        {
            // розділяє на три частини: ім'я, прізвище, оцінка
            string[] parts = MySplit(line, ' ');

            // парсить формат в інт
            int score = int.Parse(parts[2]);

            // якщо оцінка менше 60, виводить ім'я студента
            if (score < 60)
            {
                Console.WriteLine($"{parts[0]} {parts[1]}, студент набрав менше 60");
            }
        }

        // якщо ніто не набрав 60, виводить повідомлення в консоль
        if (!Array.Exists(lines, line => int.Parse(MySplit(line, ' ')[2]) < 60))
        {
            Console.WriteLine("Ніхто не набрав менше 60.");
        }
    }
}