// Example file for Advanced C#: Object Oriented Programming by Joe Marini
// Solution to the Employee Class challenge

public class Employee
{
    public Employee() { }

    // YOUR CODE GOES HERE
    public required int ID
    {
        get;
        init;
    }

    public required string Department
    {
        get;
        set;
    }

    public required string FullName
    {
        get;
        set;
    }

    public virtual void AdjustPay(decimal p) { }

    public override string ToString() => $"{ID}:{FullName}, {Department} ";
}


// DEFINE OTHER CLASSES HERE
public class HourlyEmployee : Employee
{
    public HourlyEmployee() {}

    public decimal PayRate
    {
        set;
        get;
    }

    public override void AdjustPay(decimal p)
    {
        PayRate += (PayRate * p);
    }
}

public class SalariedEmployee : Employee
{
    public decimal Salary
    {
        get;
        set;
    }

    public override void AdjustPay(decimal p)
    {
        Salary += (Salary * p);
    }
}