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
            Console.WriteLine("1. UC1 - Validate First Name");
            Console.WriteLine("2. UC2 - Validate Last Name");
            Console.WriteLine("3. UC3 - Validate Email Address");
            Console.WriteLine("4. UC4 - Validate Mobile Number");
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
                case 4:
                    UCFourPattern.ValidateMobileNumber();
                    break;
                default:
                    Console.WriteLine("Choose a appropriate option");
                    break;
            }
            Console.ReadLine();
        }
    }
}
