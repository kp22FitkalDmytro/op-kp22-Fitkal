using System;

public class Employee : IEquatable<Employee>
{
    private string surname;
    private int id;
    private int salary;
    private int taxes;
    private int pureIncome;

    public Employee(string surname, int id, int salary, int taxes)
    {
        this.surname = surname;
        this.id = id;
        this.salary = salary;
        this.taxes = taxes;
    }

    public int GetPureIncome()
    {
        if (IsCorrectValues()) pureIncome = salary - taxes;
        return pureIncome;
    }

    public void DisplayInformation()
    {
        this.GetPureIncome();
        Console.WriteLine($"{surname} receive salary {salary}, and pays taxes in such amount {taxes}, so pure icome is {pureIncome}");
    }

    public bool Equals(Employee? other)
    {
        return this.surname == other.surname && id == other.id;
    }

    public int WhichOperation(string type)
    {
        type = type.ToLower();
        switch (type)
        {
            case "salary":
                return salary;
            case "taxes":
                return taxes;
            case "pureincome":
                return pureIncome;
            default:
                Console.WriteLine("Incorrect type of funds");
                return 0;
        }
    }
    public bool IsCorrectValues()
    {
        return salary > taxes && salary > 0 && id > 0;
    }
}