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
            Console.WriteLine("2. UC1 - Valid Last Name");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    UCOnePattern.ValidateFirstName();
                    break;
               /* case 2:
                    UCTwoPattern.ValidateLastName();
                    break;*/
                default:
                    Console.WriteLine("Choose a appropriate option");
                    break;
            }
            Console.ReadLine();
        }
    }
}
