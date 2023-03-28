using System;
using System.IO;

class Program
{
    static void Main()
    {
        // читає слова з файліка
        string[] words = File.ReadAllLines("input.txt");

        // сортує за алфавітом
        Array.Sort(words);

        // виписує просортовані числа в файлік
        File.WriteAllLines("output.txt", words);

        Console.WriteLine("Слова просортовані та написані в output.txt:");
        Console.WriteLine(string.Join(", ", words));
    }
}