using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class A2Q5
    {
        public static void password()
        {
           
            while (true)
            {
                Console.Write("Enter a password: ");
                string password = Console.ReadLine();

          
                bool isValid = ValidatePassword(password);

               
                if (isValid)
                {
                    Console.WriteLine("Password is valid.");
                    break;
                }

                Console.WriteLine(); 
            }

            
            Console.WriteLine("Press Enter to exit...");
            Console.ReadLine();
        }

        static bool ValidatePassword(string password)
        {
            bool isValid = true;

         
            if (password.Length < 8)
            {
                Console.WriteLine("Password must be at least 8 characters long.");
                isValid = false;
            }

           
            if (!Regex.IsMatch(password, "[A-Z]"))
            {
                Console.WriteLine("Password must contain at least one uppercase letter.");
                isValid = false;
            }

            
            if (!Regex.IsMatch(password, "[a-z]"))
            {
                Console.WriteLine("Password must contain at least one lowercase letter.");
                isValid = false;
            }

           
            if (!Regex.IsMatch(password, "[0-9]"))
            {
                Console.WriteLine("Password must contain at least one number.");
                isValid = false;
            }

            return isValid;
        }
    }
}
    