using System;
using System.Collections.Generic;
using System.Linq;

namespace Dictionarys
{
    class Program
    {                
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Customer c1 = new Customer() { Id = 1, Name = "jack",Salary=5000 };
            Customer c2 = new Customer() { Id = 2, Name = "black",Salary=10000 };
            Dictionary<int, Customer> dic = new Dictionary<int, Customer>();

            Customer[] egn = new Customer[5];
            egn[0] = new Customer { Id = 1, Name = "A", Salary = 1000 };
            egn[1] = new Customer { Id = 2, Name = "B", Salary = 2000 };
            egn[2] = new Customer { Id = 3, Name = "C", Salary = 3000 };

            Dictionary<int,Customer> dick =  egn.ToDictionary(cus => cus.Id,cus => cus);
            for (int i = 0; i < dick.Count(dvp => dvp.Value.Salary >1000);i++)
            {
                Console.WriteLine("High");
            }
            

            dic.Add(1,c1);
            dic.Add(2, c2);
            if(dic.TryGetValue(2,out c2))
            {
                Console.WriteLine(dic[2].Name);
            }
            foreach (KeyValuePair<int,Customer> keyValuePair in dic)
            {                
                Console.WriteLine($"The Key is {keyValuePair.Key}");
                Console.WriteLine($"Id : {keyValuePair.Value.Id}");
                Console.WriteLine($"Name : {keyValuePair.Value.Name}");
                Console.WriteLine("---------------");
            }
        }
    }
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
    
}
