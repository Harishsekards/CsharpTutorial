using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Sort_List_Of_ComplexType
{
    public class Employee
    {
        public int Salary { get; set; }
        public string Name { get; set; }
    }

    public class sortByAny : IComparer<Employee>
    {       
        public int Compare(Employee x,Employee y)
        {
            return x.Salary.CompareTo(y.Salary);
        }
    }
    class Program
    {
       static List<Employee> employees = new List<Employee>()
        {
            new Employee{ Name = "Ajai",Salary=75000},
            new Employee{ Name = "Balu",Salary=85000},
            new Employee{ Name = "Chandru",Salary=65000},
            new Employee{ Name = "Dinesh",Salary=95000},
            new Employee{ Name = "Eshwar",Salary=55000},
        };
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            sortByAny sortByAny = new sortByAny();
            employees.Sort(sortByAny);
            foreach (var employee in employees)
            {
                Console.WriteLine(employee.Salary);
            }
        }
    }
}
