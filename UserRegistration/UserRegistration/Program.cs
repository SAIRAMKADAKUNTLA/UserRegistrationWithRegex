using System;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("User registration with the regex");
            CheckValidation check = new CheckValidation();
            check.validateFirstName("Sairam");
            check.validateLastName("Kadakuntla");
            check.validateEmail("sairam.kadakuntla@gmail.co.in");
            check.validateMobileNo("91 1234567890");
            check.validatePassword("Sairam@123");

        }
    }
}
