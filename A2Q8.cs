using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class A2Q8
    {
        public static void expense()
        {
            const int monthsInYear = 12;
            double[] expenses = new double[monthsInYear];
            string[] monthNames = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

            
            for (int i = 0; i < monthsInYear; i++)
            {
                Console.Write($"Enter expenses for {monthNames[i]}: ");
                string input = Console.ReadLine();
                double expense;

               
                if (double.TryParse(input, out expense) && expense >= 0)
                {
                    expenses[i] = expense;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a positive number.");
                    i--; 
                }
            }

            
            double totalExpenses = 0;
            foreach (double expense in expenses)
            {
                totalExpenses += expense;
            }

     
            int maxIndex = 0, minIndex = 0;
            for (int i = 1; i < monthsInYear; i++)
            {
                if (expenses[i] > expenses[maxIndex])
                {
                    maxIndex = i;
                }
                if (expenses[i] < expenses[minIndex])
                {
                    minIndex = i;
                }
            }

       
            Console.WriteLine($"\nTotal expenses for the year: Rs. {totalExpenses}");
            Console.WriteLine($"Month with the highest expenses: {monthNames[maxIndex]} (Rs. {expenses[maxIndex]})");
            Console.WriteLine($"Month with the lowest expenses: {monthNames[minIndex]} (Rs. {expenses[minIndex]})");

            
            Console.WriteLine("\nPress Enter to exit...");
            Console.ReadLine();
        }
    }
}
