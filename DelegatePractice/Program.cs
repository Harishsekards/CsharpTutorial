using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace DelegatePractice
{
    delegate bool isPromotable(Employee employee);
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int salary { get; set; }
        public int Experience { get; set; }

        public static bool isEligible(Employee employee)
        {
            if(employee.Experience > 3)
            {
                return true;
            }

            return false;
        }
    }
    class Program
    {
        public static void promoteEmployee(List<Employee> list,isPromotable isEligible)
        {
            foreach (Employee emp in list)
            {
                if (isEligible(emp))
                {
                    Console.WriteLine($"{emp.Name} is Eligible for promotion");
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            isPromotable isPromotable = new isPromotable(Employee.isEligible);
            List<Employee> employees = new List<Employee>()
            {
                new Employee{Id = 1,salary = 5000,Name="H",Experience=5 },
                new Employee{Id = 2,salary = 6000,Name="I" ,Experience = 6},
                new Employee{Id = 1,salary = 7000,Name="J" ,Experience = 1}
            };

            promoteEmployee(employees,isPromotable);
           
        }
    }
}
