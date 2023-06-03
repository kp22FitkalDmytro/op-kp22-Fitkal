using System;

public class Employee : IEquatable<Employee>
{
    private string Surname;
    private int ID;
    private int Salary;
    private int Taxes;
    private int PureIncome;

    public Employee(string surname, int id, int salary, int taxes)
    {
        this.Surname = surname;
        this.ID = id;
        this.Salary = salary;
        this.Taxes = taxes;
    }

    public int GetPureIncome()
    {
        if (IsCorrectValues()) PureIncome = Salary - Taxes;
        return PureIncome;
    }

    public void DisplayInformation()
    {
        this.GetPureIncome();
        Console.WriteLine($"Surname-"+Surname);
        Console.WriteLine("Salary " +Salary);
        Console.WriteLine("Taxes " +Taxes);
        Console.WriteLine("PureIncome" +PureIncome);
    }

    public bool Equals(Employee? other)
    {
        return this.Surname == other.Surname && ID == other.ID;
    }

    public int WhichOperation(string type)
    {
        type = type.ToLower();
        switch (type)
        {
            case "Salary":
                return Salary;
            case "Taxes":
                return Taxes;
            case "Pureincome":
                return PureIncome;
            default:
                Console.WriteLine("Wrong type");
                return 0;
        }
    }
    public bool IsCorrectValues()
    {
        return Salary > Taxes && Salary > 0 && ID > 0;
    }
}
