using UserRegistrationUsingRegex;

namespace TestUserRegistration
{
    [TestClass]
    public class TeatAllUserEntry

    {
        [TestMethod]
        public void TestFirstName()
        {
            string firstName = "Roanak";
            UC12ValidateUserEntryUsingCustomException uc12 = new UC12ValidateUserEntryUsingCustomException();
            string actual = uc12.ValidateFirstName(firstName);
            Assert.AreEqual(firstName, actual);
            Console.WriteLine(actual);
        }

        [TestMethod]
        public void TestLastName()
        {
            string lastName = "Sharma";
            UC12ValidateUserEntryUsingCustomException uc12 = new UC12ValidateUserEntryUsingCustomException();
            string actual = uc12.ValidateLastName(lastName);
            Assert.AreEqual(lastName, actual);
            Console.WriteLine(actual);
        }


        [TestMethod]
        public void TestEmail()
        {
            string email = "ronak.100@gmail.com";
            UC12ValidateUserEntryUsingCustomException uc12 = new UC12ValidateUserEntryUsingCustomException();
            string actual = uc12.ValidateEmail(email);
            Assert.AreEqual(email, actual);
            Console.WriteLine(actual);
        }

        [TestMethod]
        public void TestMobileNumber()
        {
            string mobileNum = "+91 6859632145";
            UC12ValidateUserEntryUsingCustomException uc12 = new UC12ValidateUserEntryUsingCustomException();
            string actual = uc12.ValidateMobileNumber(mobileNum);
            Assert.AreEqual(mobileNum, actual);
            Console.WriteLine(actual);
        }


        [TestMethod]
        public void TestPassword()
        {
            string password = "Roanak#12";
            UC12ValidateUserEntryUsingCustomException uc12 = new UC12ValidateUserEntryUsingCustomException();
            string actual = uc12.ValidatPassword(password);
            Assert.AreEqual(password, actual);
            Console.WriteLine(actual);
        }

    }
}