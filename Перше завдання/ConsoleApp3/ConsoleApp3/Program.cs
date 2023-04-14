using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class UnitTests
    {
        public bool PureIncomeChecker()
        {

            int salary = 220;
            int taxes = 220;
            int expected1 = 0;

            Employee employee1 = new Employee("Maslak", 2, salary, taxes);
            int actual1 = employee1.GetPureIncome();
            if (actual1 != expected1)
            {
                Console.WriteLine("First test faild");
                return false;
            }

            int salary2 = 2;
            int taxes2 = -220;
            int expected2 = 222;

            Employee employee2 = new Employee("Maslak", 1, salary2, taxes2);
            int actual2 = employee2.GetPureIncome();
            if (actual2 != expected2)
            {
                Console.WriteLine("Second test failed");
                return false;
            }

            int salary3 = -220;
            int taxes3 = -220;
            int expected3 = 0;

            Employee employee3 = new Employee("Maslak", 3, salary3, taxes3);
            int actual3 = employee3.GetPureIncome();
            if (actual3 != expected3)
            {
                Console.WriteLine("Third test failed");
                return false;
            }

            int salary4 = 100;
            int taxes4 = 10;
            int expected4 = 90;

            Employee employee4 = new Employee("Maslak", 3, salary4, taxes4);
            int actual4 = employee4.GetPureIncome();
            if (actual4 != expected4)
            {
                Console.WriteLine("Fourth test faild");
                return false;
            }
            Console.WriteLine("All Tests passed");
            return true;
        }
    }
}
