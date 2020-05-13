using System;
using System.Runtime.Serialization;

namespace ExceptionHandling
{
    [Serializable]
    public class UserLoggedInException : Exception
    {
        public UserLoggedInException() :
            base()
        {

        }
        public UserLoggedInException(string message):
            base(message)
        {

        }
        public UserLoggedInException(string message, Exception InnerException):
            base(message,InnerException)
        {

        }
        public UserLoggedInException(SerializationInfo info,StreamingContext context):base(info,context)
        {

        }
    }
    class Program
    {
      
      public   static void Main(string[] args)
        {
            //throw new UserLoggedInException("User already loggedIn");
            Console.WriteLine("Enter a number");
            string input = Console.ReadLine();
            int A = Int32.Parse(input);
            int B = Convert.ToInt32(input);
          //  int D;
            bool c = Int32.TryParse(input, out int D);
            Console.WriteLine(A);
           Console.WriteLine(B);
            Console.WriteLine(c);

        }
    }
}
