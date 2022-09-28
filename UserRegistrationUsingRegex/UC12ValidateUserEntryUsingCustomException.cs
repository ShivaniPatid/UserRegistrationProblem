using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationUsingRegex
{
    public class UC12ValidateUserEntryUsingCustomException
    {
        

        public string ValidateFirstName(string firstName)
        {


            string patternForFirstName = "^[A-Z]{1}[a-z]{2,}$";
            try 
            {
                if (Regex.IsMatch(firstName, patternForFirstName))
                {
                    return firstName;

                }
                else
                {
                    throw new CustomException("Inavalid First Name");

                }
            }
            catch(CustomException ex)
            {
                return ex.Message;
            }
            
        }

        public string ValidateLastName(string lastName)
        {
            string patternForLastName = "^[A-Z]{1}[a-z]{2,}$";
            try
            {
                if (Regex.IsMatch(lastName, patternForLastName))
                {
                    return lastName;

                }
                else
                {
                    throw new CustomException("Inavalid Last Name");

                }
            }
            catch (CustomException ex)
            {
                return ex.Message;
                
            }

        }

        public string ValidateEmail(string email)
        {
            string patternForEmail = @"^([a-z]+)([._+-a-z0-9_\+\-]+)?@([a-z]+)\.([a-z]{2,4})(\.[a-z]{2,4})?$";
            try
            {
                if (Regex.IsMatch(email, patternForEmail))
                {
                    return email;

                }
                else
                {
                    throw new CustomException("Inavalid Email");

                }
            }
            catch (CustomException ex)
            {
                return ex.Message;

            }

        }

        public string ValidateMobileNumber(string mobileNum)
        {
            
            string patternForMobileNum = "^[+][91]{2}[: :][6-9]{1}[0-9]{9}$";
            string patternForPassword = "^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[!@#$%^&*()_+=\\[{\\]};:<>|./?,-]).{8,}$";
            try
            {
                if (Regex.IsMatch(mobileNum, patternForMobileNum))
                {
                    return mobileNum;

                }
                else
                {
                    throw new CustomException("Inavalid Email");

                }
            }
            catch (CustomException ex)
            {
                return ex.Message;

            }

        }

        public string ValidatPassword(string password)
        {

            string patternForPassword = "^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[!@#$%^&*()_+=\\[{\\]};:<>|./?,-]).{8,}$";
            try
            {
                if (Regex.IsMatch(password, patternForPassword))
                {
                    return password;

                }
                else
                {
                    throw new CustomException("Inavalid Email");

                }
            }
            catch (CustomException ex)
            {
                return ex.Message;

            }

        }
    }

    public class CustomException : Exception
    {
        public CustomException(string message) : base(message)
        {

        }
    }
}
