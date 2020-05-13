using System;

class Employee
{
    public int Salary { get; set; }
    public int Experience { get; set; }
    public string Name { get; set; }
}
delegate bool isPromotable(Employee employee);

public static bool Promote(Employee employee)
{
    if (employee.Experience >= 5)
    {
        return true;
    }
    return false;
}
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");
    }
}

