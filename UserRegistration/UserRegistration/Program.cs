using System;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("User registration with the regex");
            CkeckValidation check = new CkeckValidation();
            check.CheckName("Sairam");

        }
    }
}
