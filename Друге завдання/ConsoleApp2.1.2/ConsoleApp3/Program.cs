using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NestedClass empoloyees = new NestedClass();
            NestedClass.Employee dimas = new NestedClass.Employee("Maslak", 4, 220, 20);
            Console.WriteLine(dimas.GetPureIncome());
            empoloyees.Display();
            Console.WriteLine(empoloyees.GetSum("taxes"));
        }
    }
}
