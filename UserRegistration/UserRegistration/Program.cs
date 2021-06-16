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
            check.CheckMobileNumber("91 1234567890");
            check.CheckPassword("sairam12234");

        }
    }
}
