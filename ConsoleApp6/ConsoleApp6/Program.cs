using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Score { get; set; }

    public Student(string firstName, string lastName, int score)
    {
        FirstName = firstName;
        LastName = lastName;
        Score = score;
    }
}

class Program
{
    static void Main(string[] args)
    {
        string csvFilePath = "students.csv";
        string binaryFilePath = "students.bin";
        string filteredBinaryFilePath = "filtered_students.bin";

        // Read CSV file
        List<Student> students = ReadStudentsFromCsv(csvFilePath);

        // Write binary file
        WriteStudentsToBinary(students, binaryFilePath);

        // Filter students by score and write filtered binary file
        FilterStudentsByScore(students, 95, filteredBinaryFilePath);
    }

    static List<Student> ReadStudentsFromCsv(string filePath)
    {
        List<Student> students = new List<Student>();

        using (var reader = new StreamReader(filePath))
        {
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(',');

                string firstName = values[0].Trim();
                string lastName = values[1].Trim();
                int score = int.Parse(values[2].Trim());

                students.Add(new Student(firstName, lastName, score));
            }
        }

        return students;
    }

    static void WriteStudentsToBinary(List<Student> students, string filePath)
    {
        using (BinaryWriter writer = new BinaryWriter(File.Open(filePath, FileMode.Create)))
        {
            foreach (var student in students)
            {
                writer.Write(student.FirstName);
                writer.Write(student.LastName);
                writer.Write(student.Score);
            }
        }
    }

    static void FilterStudentsByScore(List<Student> students, int scoreThreshold, string filePath)
    {
        List<Student> filteredStudents = students.Where(s => s.Score > scoreThreshold).ToList();

        using (BinaryWriter writer = new BinaryWriter(File.Open(filePath, FileMode.Create)))
        {
            writer.Write(filteredStudents.Count);

            foreach (var student in filteredStudents)
            {
                writer.Write(student.FirstName);
                writer.Write(student.LastName);
                writer.Write(student.Score);
            }
        }
    }
}




