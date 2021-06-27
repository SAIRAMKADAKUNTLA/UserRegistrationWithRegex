using NUnit.Framework;
using System.Text.RegularExpressions;
using UserRegistration;

namespace UserRegistrationTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
           
         
        }

        [Test]
      
        public void GivenDetails_returnvalidateresults()
        {
            CheckValidation check = new CheckValidation();
            string first=check.validateFirstName("Sairam");
            string last=check.validateLastName("Kadakuntla");
            string email= check.validateEmail("sairam.kadakuntla@gmail.co.in");
            string mobile=check.validateMobileNo("91 1234567890");
            string password=check.validatePassword("Sairam@123");
            Assert.AreEqual(first, "Happy");
            Assert.AreEqual(last, "Happy");
            Assert.AreEqual(email, "Happy");
            Assert.AreEqual(mobile, "Happy");
            Assert.AreEqual(password, "Happy");
        }
        [Test]
        [TestCase("sairam@gmail.com")]
        [TestCase("abc.100@yahoo.com")]
        [TestCase("abc-100@abc.net")]
        [TestCase("abc.100@abc.com.au")]
        [TestCase("abc+100@gmail.com")]
        public void Given_MultipleEmails_Returns_Result(string email)
        {
            CheckValidation checkValidation = new CheckValidation();
            string result = checkValidation.validateEmail(email);
            Assert.AreEqual(result, email);
        }
    }
}