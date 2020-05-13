using System;
using System.Reflection;

namespace ReflectionTutorial
{
    class Customer
    {
        private int _id;
        public int Id { get; set; }
        public string CustomerName { get; set; }

        public void PrintName()
        {

        }
        public void PrintId()
        {

        }
    }
    class Program
    {
        static void Main()
        {
            Type type = Type.GetType("ReflectionTutorial.Customer");
            PropertyInfo[] property = type.GetProperties();
            foreach (PropertyInfo prop in property)
            {
                Console.WriteLine(prop);
            }
            MethodInfo[] metho =  type.GetMethods();
            foreach (MethodInfo prop in metho)
            {
                Console.WriteLine(prop);
            }
            Console.WriteLine("Hello World!");
        }
    }
}
