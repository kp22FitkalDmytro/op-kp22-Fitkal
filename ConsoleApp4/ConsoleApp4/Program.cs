using System;
using System.IO;

class Program
{
    static void Main()
    {
        // читає файлік 
        string[] lines = File.ReadAllLines("students.txt");

        // дивиться чи є оцінка менша 60
        foreach (string line in lines)
        {
            // розділяє на три частини: ім'я, прізвище, оцінка
            string[] parts = line.Split(',');

            // парсить формат в інт
            int score = int.Parse(parts[2]);

            // якщо оцінка менше 60, виводить ім'я студента
            if (score < 60)
            {
                Console.WriteLine($"{parts[0]} {parts[1]}");
            }
        }

        // якщо ніто не набрав 60, виводить повідомлення в консоль
        if (!Array.Exists(lines, line => int.Parse(line.Split(',')[2]) < 60))
        {
            Console.WriteLine("Ніхто не набрав менше 60.");
        }
    }
}