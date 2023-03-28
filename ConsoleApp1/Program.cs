using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        
        string filePath = "test.txt"; // путь до файла
        List<string> lines = new List<string>();
        Console.WriteLine("If you want to stop and get the result press 'stop'");
        while (true)
        {
            string a = Console.ReadLine();
            if (a == "stop")
            {
                break;
            }
                    
            lines.Add(a);
            

        }
        // команда шо пише в файлі
        File.WriteAllLines(filePath, lines);

        // читає слова з файла і транслює їх на екран
        Console.WriteLine("");
        string[] fileLines = File.ReadAllLines(filePath);
        foreach (string line in fileLines)

        {
            Console.WriteLine(line);
        }

        Console.ReadLine(); // ждем і зчитуем що напише людина шось 
    }
}