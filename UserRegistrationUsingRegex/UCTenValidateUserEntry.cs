using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationUsingRegex
{
    public class UCTenValidateUserEntry
    {
        public string firstName;
        public string lastName;
        public string email;
        public string mobileNum;
        public string password;

        
        
        public UCTenValidateUserEntry(string firstName,string lastName,string email,string mobileNum,string password)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.mobileNum = mobileNum;
            this.password = password;
        }
       
        public string ValidateUserEntry()
        {
            

            string patternForFirstName = "^[A-Z]{1}[a-z]{2,}$";
            string patternForLastName = "^[A-Z]{1}[a-z]{2,}$";
            string patternForEmail= @"^([a-z]+)([._+-a-z0-9_\+\-]+)?@([a-z]+)\.([a-z]{2,4})(\.[a-z]{2,4})?$";
            string patternForMobileNum = "^[+][91]{2}[: :][6-9]{1}[0-9]{9}$";
            string patternForPassword = "^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[!@#$%^&*()_+=\\[{\\]};:<>|./?,-]).{8,}$";

            if(Regex.IsMatch(mobileNum,patternForMobileNum)&&Regex.IsMatch(lastName,patternForLastName)&&Regex.IsMatch(email,patternForEmail)&&Regex.IsMatch(mobileNum,patternForMobileNum)&&Regex.IsMatch(password,patternForPassword))
            {
                return "validates the Entry Successfully";
                
            }
            else
            {
                return "fails the Entry";
                
            } 
        }

    }
}
