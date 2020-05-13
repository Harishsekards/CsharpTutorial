using System;

namespace CsharpTutorial
{
    interface I
    {
        void functinfromI();
    }
    interface I2
    {
        void functinfromI();
    }
    class A
    {
        string messageFromA = "Hi,I'm A";
        public void functionFromA()
        {
            Console.WriteLine(messageFromA);
        }

        public virtual void polymor()
        {
            Console.WriteLine("Hi,I'm Polymor from Base");
        }
    }
    class B : A
    {
       
        public new void functionFromA()
        {
            Console.WriteLine("Hi I'm from B the derived class");
           // base.functionFromA();
        }
        public override void polymor()
        {
            Console.WriteLine("Hi,Polymor from Derived");
        }
    }
    class C : A
    {

    }

    abstract class D
    {
        public void absPrint()
        {
            Console.WriteLine("Hi from ABSPRINT");
        }
        public abstract void absPrint2();
    }

    public delegate void HelloDelegate(string msg);

    class Program : D
    {
        public static void helo(string msg2)
        {
            Console.WriteLine(msg2);
        }
      
        static void Main(string[] args)
        {
            HelloDelegate helloDelegate = new HelloDelegate(helo);
            helloDelegate("Hello fom delegta");
            //int Number = 11;
            //bool isNumber10 = (Number == 10 ? true : false);
            //Console.WriteLine("isNumber10 is {0}", isNumber10);
            //A objA = new A();
            //objA.functionFromA();
            //B objB = new B();
            //objB.functionFromA();
            //A obj2 = new B();
            //obj2.functionFromA();
            //B obj3 = new B();
            //((A)obj3).functionFromA();
            //A obj4 = new B();
            //obj4.polymor();
            //A obj5 = new C();
            //obj5.polymor();
            //Program p = new Program();
            //Program p2 = new Program();
            //p2.functinfromI();
            //((I)p).functinfromI();
            //((I2)p).functinfromI();
            //Program p = new Program();
            //p.absPrint2();

        }

        public override void absPrint2()
        {
            Console.WriteLine("Hi from absprint2");
        }

        //public void functinfromI()
        //{
        //    Console.WriteLine("Hi from I");
        //}

        //void I2.functinfromI()
        //{
        //    Console.WriteLine("Hi,from I2");
        //}
    }
}
