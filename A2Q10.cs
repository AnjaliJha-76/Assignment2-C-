using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class A2Q10
    {
        public static void salary()
        {
            // Prompt the user to input hourly wage
            Console.Write("Enter the hourly wage (in Rs.): ");
            string wageInput = Console.ReadLine();
            double hourlyWage;

            // Validate and parse the hourly wage
            if (double.TryParse(wageInput, out hourlyWage) && hourlyWage >= 0)
            {
                // Prompt the user to input hours worked per week
                Console.Write("Enter the number of hours worked per week: ");
                string hoursInput = Console.ReadLine();
                double hoursWorkedPerWeek;

                // Validate and parse the hours worked per week
                if (double.TryParse(hoursInput, out hoursWorkedPerWeek) && hoursWorkedPerWeek >= 0)
                {
                    // Calculate monthly salary
                    double weeklySalary = hourlyWage * hoursWorkedPerWeek;
                    double monthlySalary = weeklySalary * 4; // Assuming 4 weeks in a month

                    // Display the calculated monthly salary
                    Console.WriteLine($"Monthly Salary: Rs. {monthlySalary}");
                }
                else
                {
                    Console.WriteLine("Invalid input for hours worked. Please enter a valid number.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input for hourly wage. Please enter a valid number.");
            }

            // Hold the console open
            Console.WriteLine("Press Enter to exit...");
            Console.ReadLine();
        }
    }
}

