using UserRegistrationUsingRegex;

namespace TestUserRegistration
{
    [TestClass]
    public class UnitTest1

    {
        [TestMethod]
        public void HappyTestCase()
        {
            string firstName = "Roanak";
            string lastName = "Sharma";
            string email = "abc@yahoo.com";
            string mobileNum = "+91 8926351456";
            string password = "Roanak#12";

            string message= "validates the Entry Successfully";
            UCTenValidateUserEntry ucten = new UCTenValidateUserEntry(firstName,lastName,email,mobileNum,password);
            string actual=ucten.ValidateUserEntry();
            Assert.AreEqual(actual,message);
            
            
        }

        [TestMethod]
        public void SadTestCase()
        {
            string firstName = "Roanak";
            string lastName = "Sharma";
            string email = "abc@yahoo.com";
            string mobileNum = "+91 892635";
            string password = "Roanak#12";

            string message = "fails the Entry";
            UCTenValidateUserEntry ucten = new UCTenValidateUserEntry(firstName, lastName, email, mobileNum, password);
            string actual = ucten.ValidateUserEntry();
            Assert.AreEqual(actual, message);


        }
    }
}