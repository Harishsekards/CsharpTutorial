using System;
using System.Collections.Generic;

namespace Delegate
{
    public delegate bool IsPromotable(Employee employee);
    public class Employee
    {
        public int Salary { get; set; }
        public int Experience { get; set; }
        public string Name { get; set; }

        public static bool IsEligible(Employee employee)
        {
            if (employee.Experience >= 5)
            {
                return true;
            }
            return false;

        }

    }
    class Program
    {
        IsPromotable isPromotable = new IsPromotable(Employee.IsEligible);
        private static List<Employee> _empList;

        public void PromoteEmployee(List<Employee> list,IsPromotable isEligible)
        {
            foreach (Employee employee in list)
            {
                if (isEligible(employee))
                {
                    Console.WriteLine("{0} is promoted",employee.Name);
                }
            }
        }

        static void Main(string[] args)
        {
            _empList = new List<Employee>()
            {
                new Employee{Name = "jack",Experience=5,Salary=50000 },
                new Employee{Name = "jon",Experience=4,Salary=40000 },
                new Employee{Name = "jess",Experience=6,Salary=60000 },
                new Employee{Name = "jeff",Experience=7,Salary=70000 },
            };
            IsPromotable eligibility = new IsPromotable(Employee.IsEligible);
            Program program = new Program();
            program.PromoteEmployee(_empList,eligibility);
        }
    }
}
