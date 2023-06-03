using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class UserInterface
    {
        public List<Employee> employees;

        public UserInterface()
        {
            employees = new List<Employee>();
        }

        public void AddEmployee(Employee employee)
        {
            if (employees.Any(emp => emp.Equals(employee))) Console.WriteLine("already in the list");
            else employees.Add(employee);
        }
        public int GetSum(string TypeOfMoney)
        {
            int total = 0;
            bool pureIncome = TypeOfMoney.ToLower() == "pure income";
            foreach (Employee emp in employees)
            {
                if (pureIncome)
                {
                    emp.GetPureIncome();
                }
                total += emp.WhichOperation(TypeOfMoney);
            }
            return total;
        }
        public void Display()
        {
            foreach (var emp in employees)
            {
                emp.DisplayInformation();
            }
        }
    }
}
