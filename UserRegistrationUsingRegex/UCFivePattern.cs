using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationUsingRegex
{
    public class UCFivePattern
    {
        public static void validatePassword(string password)
        {
            
            var hasLowerChar = new Regex("^(?=.*[a-z]).{8,}$");

            if (!hasLowerChar.IsMatch(password))
            {
                Console.WriteLine("Password should have minimum 8 characters");
            }
            else
            {
                Console.WriteLine("Password is valid");
            }
        }
    }
}
