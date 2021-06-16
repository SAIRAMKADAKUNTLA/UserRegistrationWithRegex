using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class CkeckValidation
    {
        public void CheckName(string data)
        {
            string validateFirstName = "^[A-Z][a-z]{3,20}";
            {
                if (Regex.IsMatch(data,validateFirstName))
                Console.WriteLine("Name valide succesfully");
                else
                    Console.WriteLine("Invalid name");
            }
        }
    }
}
