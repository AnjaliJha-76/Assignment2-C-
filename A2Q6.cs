using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class A2Q6
    {
        public static void fare()
        {
            
            Console.Write("Enter the distance traveled (in kilometers): ");
            string input = Console.ReadLine();
            double distance;

            
            if (double.TryParse(input, out distance) && distance >= 0)
            {
             
                Console.Write("Enter the time of the ride (24-hour format, e.g., 21 for 9 PM): ");
                string timeInput = Console.ReadLine();
                int time;

               
                if (int.TryParse(timeInput, out time) && time >= 0 && time <= 24)
                {
                   
                    double fare = CalculateFare(distance, time);
                    Console.WriteLine($"The total fare for the ride is: Rs. {fare}");
                }
                else
                {
                    Console.WriteLine("Invalid time input. Please enter a number between 0 and 24.");
                }
            }
            else
            {
                Console.WriteLine("Invalid distance input. Please enter a positive number.");
            }

           
            Console.WriteLine("Press Enter to exit...");
            Console.ReadLine();
        }

        static double CalculateFare(double distance, int time)
        {
            const double flatRate = 20.0;         
            const double perKmRate = 10.0;        
            const double nightSurcharge = 1.5;    

            double fare = flatRate; 
            
            if (distance > 2)
            {
                fare += (distance - 2) * perKmRate;
            }

            
            if (time >= 22 || time < 6)
            {
                fare *= nightSurcharge;
                Console.WriteLine("A night surcharge has been applied.");
            }

            return fare;
        }
    }
}

