using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    public class CheckValidation
    {
        readonly string Name = "^[A-Z][a-z0-9A-Z]{3,}";
        readonly string EmailId = "^[a-z0-9A-Z]+([._+-][a-z0-9A-Z]+)*[@][a-z0-9A-Z]+[.][a-zA-Z]{2,3}(.[a-zA-Z]{2,})?$";
        readonly string mobileNo = "[1-9]{1}[0-9]{9}";
        readonly string Password = "^(?=.*[A-Z])(?=.*[0-9])(?=.*[!@#$%^&*()]){1}[a-zA-Z0-9]{5,}";
        public string validateFirstName(string name)
        {
            try
            {
                if (string.IsNullOrEmpty(name))
                {
                    throw new RegexValidationException(RegexValidationException.InvalidUserDetails.EMPTY_NAME);
                }

                else if (Regex.IsMatch(name, Name))
                {
                    Console.WriteLine("Firstname valid");
                    return "Happy";
                }
                else
                {
                    throw new RegexValidationException(RegexValidationException.InvalidUserDetails.INVALID_NAME);
                }
                
            }
            
            catch (RegexValidationException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return "Sad";
        }
        public string validateLastName(string name)
        {
            try
            {
                if (string.IsNullOrEmpty(name))
                {
                    throw new RegexValidationException(RegexValidationException.InvalidUserDetails.EMPTY_NAME);
                }
                else if (Regex.IsMatch(name, Name))
                {
                    Console.WriteLine("Lastname valid");
                    return "Happy";
                }
                else
                {
                    throw new RegexValidationException(RegexValidationException.InvalidUserDetails.INVALID_NAME);
                }
            }
            catch(RegexValidationException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);

            }
                return "Sad";
            }
        public string validateEmail(string email)
        {
            try
            {
                if (string.IsNullOrEmpty(email))
                {
                    throw new RegexValidationException(RegexValidationException.InvalidUserDetails.EMPTY_EMAIL);
                }
                else if (Regex.IsMatch(email, EmailId))
                {
                    Console.WriteLine("Email ID is Valid");
                    return "Happy";
                }
                else
                {
                    throw new RegexValidationException(RegexValidationException.InvalidUserDetails.INVALID_EMAIL);
                }
            }
            catch (RegexValidationException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }

            return "Sad";
            }
        public string validateMobileNo(string mobileno)
        {
            try
            {
                if (string.IsNullOrEmpty(mobileno))
                {
                    throw new RegexValidationException(RegexValidationException.InvalidUserDetails.EMPTY_MOBILE_NUMBER);
                }
                if (Regex.IsMatch(mobileno, mobileNo))
                {
                    Console.WriteLine("Mobile No is Valid");
                    return "Happy";
                }
                else
                {
                    throw new RegexValidationException(RegexValidationException.InvalidUserDetails.INVALID_MOBILE_NUMBER);
                }
            }
            catch (RegexValidationException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }

            return "Sad";
        }

        public string validatePassword(string password)
        {
            try
            {
                throw new RegexValidationException(RegexValidationException.InvalidUserDetails.EMPTY_PASSWORD);

                if (Regex.IsMatch(password, Password))
                {
                    Console.WriteLine("Password is Valid");
                    return "Happy";
                }
                else
                {
                    throw new RegexValidationException(RegexValidationException.InvalidUserDetails.INVALID_PASSWORD);
                }
            }
            catch (RegexValidationException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }

            return "Sad";
        }
    }
}
