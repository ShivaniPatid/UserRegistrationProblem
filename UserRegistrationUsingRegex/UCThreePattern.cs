using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationUsingRegex
{
    public class UCThreePattern
    {
        public static void ValidarEmail()
        {
            Console.WriteLine("Enter a email");
            string email = Console.ReadLine();

            string pattern = @"^([a-z]+)(\.[a-z0-9_\+\-]+)?@([a-z]+)\.([a-z]{2,4})(\.[a-z]{2})?$";

            if(Regex.IsMatch(email, pattern))
            {
                Console.WriteLine("Email is valid...");
            }
            else
            {
                Console.WriteLine("Email is not valid... Please enter a valid email address");
            }
        }
    }
}
