using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string filePath = "test.txt"; // путь до файла
        string[] lines = { "Привіт!", "Це тестовий файл." }; // то шо написати в файлі

        // команда шо пише в файлі
        File.WriteAllLines(filePath, lines);

        // читає слова з файла і транслює їх на екран
        string[] fileLines = File.ReadAllLines(filePath);
        foreach (string line in fileLines)
        {
            Console.WriteLine(line);
        }

        Console.ReadLine(); // ждем і зчитуем що напише людина шось 
    }
}