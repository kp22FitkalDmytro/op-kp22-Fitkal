using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabOP_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть число");
            float number=float.Parse(Console.ReadLine());
            Console.WriteLine(sin(number));
        }
        static double sin(double x)
        {
            double result = 0.0;
            double sign = 1.0;
            for (double power = 1.0; power <= 20.0; power += 2, sign = -sign)
            {
                result += sign * (Math.Pow(x, power) / factorial(power));
            }
            return result;
        }
        static double factorial(double n)
        {
            double result = 1.0;
            while (n > 1.0)
            {
                result *= n;
                n -= 1.0;
            }
            return result;
        }
    }
}
