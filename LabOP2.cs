using System;

namespace MyApp 
{
    internal class Program
    {
        public static bool IsPrimeNumber(int n)
        {
            var result = true;

            if (n > 1)
            {
                for (var i = 2u; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        result = false;
                        break;
                    }
                }
            }
            else
            {
                result = false;
            }

            return result;
        }
        static void Main(string[] args)           
        {
            Console.WriteLine("Введiть число");
          int number_from_console=int.Parse(Console.ReadLine());
            bool number_is_prime = IsPrimeNumber(number_from_console);
            if (number_is_prime)
            {
                Console.WriteLine("Число просте");
            }
            else 
            {
            Console.WriteLine("Число не просте");
            }
        }

    }
}