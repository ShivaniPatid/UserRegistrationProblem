using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationUsingRegex
{
    public class UC11TestEmailAddress
    {
        public string ValidateEmailAddress(string email)
        {
            string patternForEmail = @"^([a-z]+)([._+-a-z0-9_\+\-]+)?@([a-z]+)\.([a-z]{2,4})(\.[a-z]{2,4})?$";
            if(Regex.IsMatch(email, patternForEmail))
            {
                return "Valid Email Address";
            }
            else
            {
                return "Email address is not valid";
            }
        }

    }
}
