using System;

public class Program
{
    public static int a;
    public static int x;
    public static int number_to_power_up;
    public static int number_of_power_up;
    static int Fact(int n) 
    {
        int result;
        result = 1;
        for (int i = 1; i <= n; i++)
            result *= i;
        return result;
    }

    static void Main(string[] args)

    {
        Console.WriteLine("Обчислення факторiала");
        Console.Write("Введiть число  ");
       
        a = int.Parse(Console.ReadLine());
        Console.WriteLine("{0}!={1}",a,Fact(a));
        Console.WriteLine("Введiть x ");

        number_to_power_up = int.Parse(Console.ReadLine());

        number_of_power_up = a;
        Console.WriteLine("x в степенi n ");
        Console.WriteLine(Math.Pow(number_to_power_up, number_of_power_up));


    }
}