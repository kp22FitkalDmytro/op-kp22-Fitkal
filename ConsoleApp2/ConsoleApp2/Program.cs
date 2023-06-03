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

        // згенерувати 15 рандомних чисел і записати їх в  "numbers.txt"
        Random rand = new Random();
        using (StreamWriter writer = new StreamWriter("numbers.txt"))
        {
            for (int i = 0; i < 15; i++)
            {
                double num = rand.NextDouble() * 100; // генерує рандомні числа між 0 і 100
                writer.Write(num + " "); // виписує числа в файлик через пробел
            }
        }

        // находить максимальне число і записує в "max.txt"
        double max = double.MinValue;
        using (StreamReader reader = new StreamReader("numbers.txt"))
        {
            string line = reader.ReadLine();
            string[] numbers = MySplit(line, ' ');
            foreach (string number in numbers)
            {
                if (number != "")
                {
                    double num = double.Parse(number);
                    if (num > max)
                    {
                        max = num;
                    }
                }
            }
        }
        using (StreamWriter writer = new StreamWriter("max.txt"))
        {
            writer.Write(max);
        }

        // написати вміст "numbers.txt" в консоль
        using (StreamReader reader = new StreamReader("numbers.txt"))
        {
            string line = reader.ReadLine();
            Console.WriteLine(line);
        }
    }
}