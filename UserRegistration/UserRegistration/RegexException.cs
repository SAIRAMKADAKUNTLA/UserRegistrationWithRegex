using System;
using System.Collections.Generic;
using System.Text;

namespace UserRegistration
{
    public class RegexValidationException:Exception
    {
        public enum InvalidUserDetails
        {
            EMPTY_EMAIL,
            EMPTY_PASSWORD,
            EMPTY_NAME,
            EMPTY_MOBILE_NUMBER,
            INVALID_EMAIL,
            INVALID_PASSWORD,
            INVALID_NAME,
            INVALID_MOBILE_NUMBER,

        }
        public RegexValidationException(InvalidUserDetails error)
        {
            if(error == InvalidUserDetails.EMPTY_NAME)
                Console.WriteLine(error+"NAME CANT BE EMPTY");
            if(error == InvalidUserDetails.EMPTY_PASSWORD)
                Console.WriteLine(error+"PASSWORD CANT BE EMPTY");
            if (error == InvalidUserDetails.EMPTY_EMAIL)
                Console.WriteLine(error + "EMAIL CANT BE EMPTY");
            if (error == InvalidUserDetails.EMPTY_MOBILE_NUMBER)
                Console.WriteLine(error + "MOBILE NUMBER CANT BE EMPTY");
            if(error == InvalidUserDetails.INVALID_EMAIL)
                Console.WriteLine(error+"INVALID EMAIL ID");
            if (error == InvalidUserDetails.INVALID_MOBILE_NUMBER)
                Console.WriteLine(error + "INVALID MOBILE NUMBER");
            if (error == InvalidUserDetails.INVALID_NAME)
                Console.WriteLine(error + "INVALID NAME");
            if (error == InvalidUserDetails.INVALID_PASSWORD)
                Console.WriteLine(error + "INVALID PASSWORD");
        }
    }
}
