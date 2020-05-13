using System;
using System.Collections.Generic;
using System.Text;

namespace PartialClassPractice
{
    public partial class Class1A
    {
        partial void add()
        {
            Console.WriteLine("Hello from Partial");
        }
    }
}
