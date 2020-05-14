using System;

namespace Indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Employee employee = new Employee();
            Console.WriteLine(employee[1]);
            Console.WriteLine(employee[2]);
            employee[2] = "Jack";
            employee[3] = "Black";
            Console.WriteLine(employee[2]);
            Console.WriteLine(employee[3]);
        }
    }
}
