using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class A2Q3
    {
        public static void money()
        {
            
            decimal balance = 1000.00m;

            while (true)
            {
                
                Console.WriteLine("Welcome to the ATM");
                Console.WriteLine("1. Check Balance");
                Console.WriteLine("2. Deposit Money");
                Console.WriteLine("3. Withdraw Money");
                Console.WriteLine("4. Exit");
                Console.Write("Please choose an option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        
                        Console.WriteLine($"Your current balance is: Rs. {balance}");
                        break;

                    case "2":
                        
                        Console.Write("Enter the amount to deposit: Rs. ");
                        string depositInput = Console.ReadLine();
                        decimal depositAmount;

                        if (decimal.TryParse(depositInput, out depositAmount) && depositAmount > 0)
                        {
                            balance += depositAmount;
                            Console.WriteLine($"Rs. {depositAmount} has been deposited. Your new balance is: Rs. {balance}");
                        }
                        else
                        {
                            Console.WriteLine("Invalid deposit amount. Please try again.");
                        }
                        break;

                    case "3":
                       
                        Console.Write("Enter the amount to withdraw: Rs. ");
                        string withdrawInput = Console.ReadLine();
                        decimal withdrawAmount;

                        if (decimal.TryParse(withdrawInput, out withdrawAmount) && withdrawAmount > 0)
                        {
                            if (withdrawAmount <= balance)
                            {
                                balance -= withdrawAmount;
                                Console.WriteLine($"Rs. {withdrawAmount} has been withdrawn. Your new balance is: Rs. {balance}");
                            }
                            else
                            {
                                Console.WriteLine("Insufficient funds. Please try a smaller amount.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid withdrawal amount. Please try again.");
                        }
                        break;

                    case "4":
                        
                        Console.WriteLine("Thank you for using the ATM. Goodbye!");
                        return;

                    default:
                        Console.WriteLine("Invalid option. Please choose again.");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}
