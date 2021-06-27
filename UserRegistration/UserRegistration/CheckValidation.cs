using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    public class CheckValidation
    {
        string Name = "^[A-Z][a-z0-9A-Z]{3,}";
        string EmailId = "^[a-z0-9A-Z]+([._+-][a-z0-9A-Z]+)*[@][a-z0-9A-Z]+[.][a-zA-Z]{2,3}(.[a-zA-Z]{2,})?$";
        string mobileNo = "[1-9]{1}[0-9]{9}";
        string Password = "^(?=.*[A-Z])(?=.*[0-9])(?=.*[!@#$%^&*()]){1}[a-zA-Z0-9]{5,}";
        public string validateFirstName(string name)
        {
            if (Regex.IsMatch(name, Name))
            {
                Console.WriteLine("Firstname valid");
                return "Happy";
            }
            else
            {
                Console.WriteLine("Invalid");
                return "Sad";
            }
        }
        public string validateLastName(string name)
        {
            if (Regex.IsMatch(name, Name))
            {
                Console.WriteLine("Lastname valid");
                return "Happy";
            }
            else
            {
                Console.WriteLine("Invalid");
                return "Sad";
            }
        }
        public string validateEmail(string email)
        {
            if (Regex.IsMatch(email, EmailId))
            {
                Console.WriteLine("Email ID is Valid");
                return "Happy";
            }
            else
            {
                Console.WriteLine("Email is Invalid");
                return "Sad";
            }
        }
        public string validateMobileNo(string mobileno)
        {
            if (Regex.IsMatch(mobileno, mobileNo))
            {
                Console.WriteLine("Mobile No is Valid");
                return "Happy";
            }
            else
            {
                Console.WriteLine("Mobile No  is Invalid");
                return "Sad";
            }
        }

        public string validatePassword(string password)
        {
            if (Regex.IsMatch(password, Password))
            {
                Console.WriteLine("Password is Valid");
                return "Happy";
            }
            else
            {
                Console.WriteLine("Password is Invalid");
                return "Sad";
            }
        }
    }
}
