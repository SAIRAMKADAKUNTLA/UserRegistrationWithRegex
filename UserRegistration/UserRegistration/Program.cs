using System;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("User registration with the regex");
            CkeckValidation check = new CkeckValidation();
            check.CheckFirstName("Sairam");
            check.CheckLastName("Kadakuntla");
            check.CheckEmail("sairam.kadakuntla@gmail.co.in");

        }
    }
}
