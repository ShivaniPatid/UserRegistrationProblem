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
        public static void ValidateEmail()
        {
            //Console.WriteLine("Enter a email");
            //string email = Console.ReadLine();

            string pattern = @"^([a-z]+)(\.[a-z0-9_\+\-]+)?@([a-z]+)\.([a-z]{2,4})(\.[a-z]{2})?$";

            if (Regex.IsMatch("abc.100@abc.com.au", pattern))
            {
                Console.WriteLine("abc.100@abc.com.au email is valid");
            }
            else
            {
                Console.WriteLine("Email is not valid");
            }
            if (Regex.IsMatch("abc@.com.my", pattern))
            {
                Console.WriteLine("abc@.com.my email is valid...");
            }
            else
            {
                Console.WriteLine("abc@.com.my email is not valid");
            }
            if (Regex.IsMatch("abc.100@yahoo.com", pattern))
            {
                Console.WriteLine("abc.100@yahoo.com email is valid");
            }
            else
            {
                Console.WriteLine("abc.100@yahoo.com email is not valid");
            }
            if (Regex.IsMatch("abc111@abc.com,", pattern))
            {
                Console.WriteLine("abc111@abc.com email is valid...");
            }
            else
            {

                Console.WriteLine("abc111@abc.com email is not valid");
            }
            if (Regex.IsMatch("abc@yahoo.com", pattern))
            {
                Console.WriteLine("abc@yahoo.com email is valid");
            }
            else
            {
                Console.WriteLine("abc@yahoo.com email is not valid");
            }
            if (Regex.IsMatch("abc.100@yahoo.com", pattern))
            {
                Console.WriteLine("abc.100@yahoo.com email is valid");
            }
            else
            {
                Console.WriteLine("abc.100@yahoo.com email is not valid");
            }
            if (Regex.IsMatch("abc@1.com", pattern))
            {
                Console.WriteLine("abc@1.com email is valid");
            }
            else
            {
                Console.WriteLine("abc@1.com email is not valid");
            }
            if (Regex.IsMatch("abc@gmail.com.com", pattern))
            {
                Console.WriteLine("abc@gmail.com.com email is valid");
            }
            else
            {
                Console.WriteLine("abc@gmail.com.com email is not valid");
            }
            if (Regex.IsMatch("abc123@gmail.a", pattern))
            {
                Console.WriteLine("abc123@gmail.a email is valid");
            }
            else
            {
                Console.WriteLine("abc123@gmail.a email is not valid");
            }
            if (Regex.IsMatch("abc123@.com", pattern))
            {
                Console.WriteLine("abc123@.com email is valid");
            }
            else
            { 
                Console.WriteLine("abc123@.com email is not valid");
            }
            if (Regex.IsMatch("abc@gmail.com.aa.au", pattern))
            {
                Console.WriteLine("abc@gmail.com.aa.au email is valid");
            }
            else
            {
                Console.WriteLine("abc@gmail.com.aa.au email is not valid");
            }
            if (Regex.IsMatch("abc.xyz@bl.co.in", pattern))
            {
                Console.WriteLine("abc.xyz@bl.co.in email is valid");
            }
            else
            {
                Console.WriteLine("abc.xyz@bl.co.in email is not valid");
            }
        }
    }
}
