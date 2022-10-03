using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationUsingRegex
{
    public class UC13ValidateUserEntryUsingLambdaFunction
    {
        

        string patternForFirstName = "^[A-Z]{1}[a-z]{2,}$";
        string patternForLastName = "^[A-Z]{1}[a-z]{2,}$";
        string patternForEmail = @"^([a-z]+)([._+-a-z0-9_\+\-]+)?@([a-z]+)\.([a-z]{2,4})(\.[a-z]{2,4})?$";
        string patternForMobileNum = "^[+][91]{2}[: :][6-9]{1}[0-9]{9}$";
        string patternForPassword = "^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[!@#$%^&*()_+=\\[{\\]};:<>|./?,-]).{8,}$";
        public bool ValidFirstName(string firstName) => (Regex.IsMatch(firstName, patternForFirstName));
        public bool ValidLastName(string lastName) => (Regex.IsMatch(lastName, patternForLastName));
        public bool ValidEmail(string email) => (Regex.IsMatch(email, patternForEmail));
        public bool ValidMobileNum(string mobileNum) => (Regex.IsMatch(mobileNum, patternForMobileNum));
        public bool ValidPassword(string password) => (Regex.IsMatch(password, patternForPassword));

        
        public void PrintResult(bool result)
        {
            if (result)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Not valid");
            }
        }
    }

    
}
