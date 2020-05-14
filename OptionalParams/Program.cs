using System;
using System.Runtime.InteropServices;

namespace OptionalParams
{
    class Program
    {
        
        public static void Add(int FirstNum,int SecondNum,params int[] remainingNumbers)
        {
            int result = FirstNum + SecondNum;
            if (remainingNumbers != null)
            {
                foreach (int i in remainingNumbers)
                {
                    result += i;
                }
            }
            Console.WriteLine($"The result is {result}");
        }

        public static void Add(int firstNum, int SecondNum)
        {
            int result = firstNum + SecondNum;
            Console.WriteLine($"Result from second overload is {result}");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Add(1,2);
            Add(1, 3, 5, 7, 8);
            Add(1,3,new int[] { 4, 4, 5});
            
        }
    }
}
