using System;

namespace MultiCastDelegate
{
    delegate void SampleDelegate();
    class Program
    {
        public static void SampleMethoOne()
        {
            Console.WriteLine("Delegate One");
        }
        public static void SampleMethoTwo()
        {
            Console.WriteLine("Delegate Two");
        }
        static void Main(string[] args)
        {
            SampleDelegate del = new SampleDelegate(SampleMethoOne);
            SampleDelegate del2 = new SampleDelegate(SampleMethoTwo);
            SampleDelegate del3 = del + del2;
            del += SampleMethoTwo;
            del();
            del3();
        }
    }
}
