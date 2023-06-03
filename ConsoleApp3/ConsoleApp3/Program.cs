using System;
using System.IO;

class Program
{
    static void InsertionSort(string[] arr)
    {
        for (int i = 1; i < arr.Length; i++)
        {
            string current = arr[i];
            int j = i - 1;
            while (j >= 0 && arr[j].CompareTo(current) > 0)
            {
                arr[j + 1] = arr[j];
                j--;
            }
            arr[j + 1] = current;
        }
    }
    static void Main()
    {
        // читає слова з файліка
        string[] words = File.ReadAllLines("input.txt");

        // сортує за алфавітом
        InsertionSort(words);

        // виписує просортовані числа в файлік
        File.WriteAllLines("output.txt", words);

        Console.WriteLine("Слова просортовані та написані в output.txt:");
        Console.WriteLine(string.Join(", ", words));
    }
}