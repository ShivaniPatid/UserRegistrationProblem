using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrationUsingRegex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chosee a oprtion");
            Console.WriteLine("1. UC1 - Valid First Name");
            Console.WriteLine("2. UC2 - Valid Last Name");
            Console.WriteLine("3. UC3 - Valid Email Address");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    UCOnePattern.ValidateFirstName();
                    break;
                case 2:
                    UCTwoPattern.ValidateLastName();
                    break;
                case 3:
                    UCThreePattern.ValidarEmail();
                    break;
                default:
                    Console.WriteLine("Choose a appropriate option");
                    break;
            }
            Console.ReadLine();
        }
    }
}
