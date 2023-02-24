using System;
using System.IO;

class Program
{
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
            string[] numbers = line.Split(' ');
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