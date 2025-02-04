using System;

public abstract class Employee
{
    private string name;
    private int id;

    public Employee(string name, int id)
    {
        this.name = name;
        this.id = id;
    }

    public string GetName()
    {
        return name;
    }

    public int GetId()
    {
        return id;
    }

    public abstract double GetWeeklyPay();
}

public class SalariedEmployee : Employee
{
    private double salary;

    public SalariedEmployee(string name, int id, double salary)
        : base(name, id)
    {
        this.salary = salary;
    }

    public override double GetWeeklyPay()
    {
        return salary;
    }
}

public class HourlyEmployee : Employee
{
    private double hourlyRate;
    private int hoursWorked;

    public HourlyEmployee(string name, int id, double hourlyRate, int hoursWorked)
        : base(name, id)
    {
        this.hourlyRate = hourlyRate;
        this.hoursWorked = hoursWorked;
    }

    public override double GetWeeklyPay()
    {
        double overtime = 0;
        if (hoursWorked > 40)
        {
            overtime = (hoursWorked - 40) * hourlyRate * 1.5;
        }
        return (hoursWorked * hourlyRate) + overtime;
    }
}

public class CommissionEmployee : Employee
{
    private double sales;
    private double commissionRate;

    public CommissionEmployee(string name, int id, double sales, double commissionRate)
        : base(name, id)
    {
        this.sales = sales;
        this.commissionRate = commissionRate;
    }

    public override double GetWeeklyPay()
    {
        return sales * commissionRate;
    }
}

public class SalariedCommissionEmployee : Employee
{
    private double baseSalary;
    private double sales;
    private double commissionRate;

    public SalariedCommissionEmployee(string name, int id, double baseSalary, double sales, double commissionRate)
        : base(name, id)
    {
        this.baseSalary = baseSalary * 1.10; // adding 10% to base salary
        this.sales = sales;
        this.commissionRate = commissionRate;
    }

    public override double GetWeeklyPay()
    {
        return baseSalary + (sales * commissionRate);
    }
}

public class TestPayroll
{
    public static void Main()
    {
        Employee[] employees = new Employee[4];

        employees[0] = CreateSalariedEmployee();
        employees[1] = CreateHourlyEmployee();
        employees[2] = CreateCommissionEmployee();
        employees[3] = CreateSalariedCommissionEmployee();

        foreach (Employee employee in employees)
        {
            Console.WriteLine("Weekly pay for " + employee.GetName() + ": " + employee.GetWeeklyPay());
        }
    }

    public static SalariedEmployee CreateSalariedEmployee()
    {
        string name;
        int id;
        double salary;
        GetCommonEmployeeDetails(out name, out id);
        salary = GetNonNegativeDouble("Salary");
        return new SalariedEmployee(name, id, salary);
    }

    public static HourlyEmployee CreateHourlyEmployee()
    {
        string name;
        int id;
        double hourlyRate;
        int hoursWorked;
        GetCommonEmployeeDetails(out name, out id);
        hourlyRate = GetNonNegativeDouble("Hourly Rate");
        hoursWorked = GetNonNegativeInt("Hours Worked");
        return new HourlyEmployee(name, id, hourlyRate, hoursWorked);
    }

    public static CommissionEmployee CreateCommissionEmployee()
    {
        string name;
        int id;
        double sales;
        double commissionRate;
        GetCommonEmployeeDetails(out name, out id);
        sales = GetNonNegativeDouble("Sales");
        commissionRate = GetNonNegativeDouble("Commission Rate");
        return new CommissionEmployee(name, id, sales, commissionRate);
    }

    public static SalariedCommissionEmployee CreateSalariedCommissionEmployee()
    {
        string name;
        int id;
        double baseSalary;
        double sales;
        double commissionRate;
        GetCommonEmployeeDetails(out name, out id);
        baseSalary = GetNonNegativeDouble("Base Salary");
        sales = GetNonNegativeDouble("Sales");
        commissionRate = GetNonNegativeDouble("Commission Rate");
        return new SalariedCommissionEmployee(name, id, baseSalary, sales, commissionRate);
    }

    public static void GetCommonEmployeeDetails(out string name, out int id)
    {
        Console.WriteLine("Enter Employee Details:");
        Console.Write("Name: ");
        name = Console.ReadLine();
        Console.Write("ID: ");
        while (!int.TryParse(Console.ReadLine(), out id) || id < 0)
        {
            Console.WriteLine("Please enter a valid non-negative integer for ID.");
        }
    }

    public static double GetNonNegativeDouble(string fieldName)
    {
        double value;
        Console.Write(fieldName + ": ");
        while (!double.TryParse(Console.ReadLine(), out value) || value < 0)
        {
            Console.WriteLine("Please enter a valid non-negative value for " + fieldName + ".");
        }
        return value;
    }

    public static int GetNonNegativeInt(string fieldName)
    {
        int value;
        Console.Write(fieldName + ": ");
        while (!int.TryParse(Console.ReadLine(), out value) || value < 0)
        {
            Console.WriteLine("Please enter a valid non-negative value for " + fieldName + ".");
        }
        return value;
    }
}
