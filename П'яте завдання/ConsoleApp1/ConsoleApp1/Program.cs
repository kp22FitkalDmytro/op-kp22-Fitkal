using System;
using task3;
public class Program
{
    static void Main(string[] args)
    {
        UnitTests unitTests = new UnitTests();
        Console.WriteLine(unitTests.Test());
        Vector vector = new Vector(6, -1, 0, 5);
        Vector vector2 = new Vector(8, 4, 20, 10);
        Console.WriteLine(vector + vector2);
        Console.WriteLine(vector * vector2);
        Console.WriteLine(vector / vector2);
    }
}