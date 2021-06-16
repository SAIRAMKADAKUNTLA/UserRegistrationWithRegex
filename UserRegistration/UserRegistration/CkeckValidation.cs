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
            string validateFirstName = "^[A-Z][a-z]{3,20}";
            {
                if (Regex.IsMatch(data,validateFirstName))
                Console.WriteLine("Name valid succesfully");
                else
                    Console.WriteLine("Invalid name");
            }
        }
        public void CheckLastName(string data)
        {
            string validateLastName = "^[A-Z][a-z]{3,20}";
            {
                if(Regex.IsMatch(data,validateLastName))
                    Console.WriteLine("NAME VALID SUCCESFULLY");
                else
                    Console.WriteLine("INVALID NAME");
            }
        }
    }
}
