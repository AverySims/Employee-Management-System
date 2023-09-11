namespace EmployeeProgram;

// Base class: Employee
public class Employee
{
    public string Name { get; set; }
    public string Title { get; set; }
    public double Salary { get; set; }

    public Employee(string name, string title, double salary)
    {
        Name = name;
        Title = title;
        Salary = salary;
    }
    
    public virtual double CalculateMonthlySalary()
    {
        return Salary / 12.0;
    }
}

// Derived class: Manager
public class Manager : Employee
{
    public int Bonus { get; set; }

    public Manager(string name, string title, double salary, int bonus) : base(name, title, salary)
    {
        Bonus = bonus;
    }
    
    public override double CalculateMonthlySalary()
    {
        return (Salary + Bonus) / 12.0;
    }
}

// Derived class: Engineer
public class Engineer : Employee
{
    public int OvertimeHours { get; set; }

    public Engineer(string name, string title, double salary, int overtimeHours) : base(name, title, salary)
    {
        OvertimeHours = overtimeHours;
    }

    public override double CalculateMonthlySalary()
    {
        return (Salary + (OvertimeHours * 20)) / 12.0;
    }
}

// Derived class: Salesperson
public class Salesperson : Employee
{
    public double Commission { get; set; }

    public Salesperson(string name, string title, double salary, double commission) : base(name, title, salary)
    {
        Commission = commission;
    }

    public override double CalculateMonthlySalary()
    {
        return (Salary + (Commission * 0.1)) / 12.0;
    }
}