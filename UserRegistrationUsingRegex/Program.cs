using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Services;
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
            Console.WriteLine("5. UC5 - Validate password Rule1 - Password should have minimum 8 characters");
            Console.WriteLine("6. UC6 - Validate password Rule2 - Password should have at least 1 upper character");
            Console.WriteLine("7. UC7 - Validate password Rule3 - Password should have at least 1 numeric number");
            Console.WriteLine("8. UC8 - Validate password Rule4 - Password should have at least 1 special character");
            Console.WriteLine("9. UC9 - email samples provided separately");
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
                case 5:
                    Console.WriteLine("Enter a password : ");
                    string input1 = Console.ReadLine();
                    UCFivePattern.validatePassword(input1);
                    break;
                case 6:
                    Console.WriteLine("Enter a password : ");
                    string input2 = Console.ReadLine();
                    UCSixPattern.ValidatePassword(input2);
                    break;
                case 7:
                    Console.WriteLine("Enter a password : ");
                    string input3 = Console.ReadLine();
                    UCSevenPattern.ValidatePassword(input3);
                    break;
                case 8:
                    Console.WriteLine("Enter a password : ");
                    string input4 = Console.ReadLine();
                    UCEightPattern.ValidatePassword(input4);
                    break;
                case 9:
                    Console.WriteLine("Enter email");
                    string email=Console.ReadLine();
                    UCNinePattern.ValidateEmail(email);
                    break;
                default:
                    Console.WriteLine("Choose a appropriate option");
                    break;
            }
            Console.ReadLine();
        }
    }
}
