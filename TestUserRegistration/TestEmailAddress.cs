using UserRegistrationUsingRegex;

namespace TestUserRegistration
{
    [TestClass]
    public class TestEmailAddress

    {
        [TestMethod]
        public void TestingEmailAddress()
        {
            
            string email = "abc@yahoo.com";
            string message = "Valid Email Address";
            UC11TestEmailAddress uc11 = new UC11TestEmailAddress();
            string actual=uc11.ValidateEmailAddress(email);
            Assert.AreEqual(actual,message);


        }

        
    }
}