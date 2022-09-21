using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationUsingRegex
{
    public class UCNinePattern
    {
        public static void ValidateEmail(string email)
        {
            NLog obj = new NLog();

            string pattern = @"^([a-z]+)([._+-a-z0-9_\+\-]+)?@([a-z]+)\.([a-z]{2,4})(\.[a-z]{2,4})?$";

            if (Regex.IsMatch(email, pattern))
            {
                obj.LogInfo(email + " email is valid");
            }
            else
            {
                obj.LogInfo(email + " email is not valid");
            }
        }
    }
}
