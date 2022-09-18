using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationUsingRegex
{
    public class UCSixPattern
    {
        public static void ValidatePassword(string password)
        {
            var hasLowerChar = new Regex(@"[a-z]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasMiniChars = new Regex(@".{8,}");
            var pattern = new Regex("^(?=.*[a-z])(?=.*[A-Z]).{8,}$");
            if (!hasMiniChars.IsMatch(password))
            {
                Console.WriteLine("Password should have minimum 8 characters");
            }
            else if (!hasLowerChar.IsMatch(password))
            {
                Console.WriteLine("Password should have at least 1 lower char");
            }
            else if (!hasUpperChar.IsMatch(password))
            {
                Console.WriteLine("Password should have at leat one upper character");
            }
            else if(pattern.IsMatch(password))
            {
                Console.WriteLine("Password is valid");
            }
        }
    }
}
