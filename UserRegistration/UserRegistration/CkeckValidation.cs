using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class CkeckValidation
    {
        public void CheckFirstName(string data)
        {
            string validateFirstName = "^[A-Z][a-z]{3,20}$";
            {
                if (Regex.IsMatch(data,validateFirstName))
                Console.WriteLine("Name valid succesfully");
                else
                    Console.WriteLine("Invalid name");
            }
        }
        public void CheckLastName(string data)
        {
            string validateLastName = "^[A-Z][a-z]{3,20}$";
            {
                if(Regex.IsMatch(data,validateLastName))
                    Console.WriteLine("NAME VALID SUCCESFULLY");
                else
                    Console.WriteLine("INVALID NAME");
            }
        }
        public void CheckEmail(string data)
        {
            string validateEmail = "^[a-zA-Z0-9]{3,20}.[a-zA-Z0-9]{3,20}@[a-zA-Z]{2,10}.(com|co.in|co.uk)$";
            {
                if(Regex.IsMatch(data,validateEmail))
                    Console.WriteLine("EMAIL VALID SUCCESFULLY");
                else
                    Console.WriteLine("INVALID EMAIL");
            }
        }
        public void CheckMobileNumber(string data)
        {
            string validateMobileNumber = "^[0-9]{2,4} [0-9]{10,15}$";
            if(Regex.IsMatch(data,validateMobileNumber))
                Console.WriteLine("NUMBER VALID SUCCESFULLY");
            else
                Console.WriteLine("INVALID NUMBER");
        }
    }
}
