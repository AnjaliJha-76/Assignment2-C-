using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class A2Q2
    {
        public static void temperature()
        {
            
            Console.Write("Enter the temperature in Celsius: ");
            string input = Console.ReadLine();

            
            decimal celsius;
            if (decimal.TryParse(input, out celsius))
            {
              
                decimal fahrenheit = (celsius * 9 / 5) + 32;

            
                Console.WriteLine("The temperature in Fahrenheit is: " + fahrenheit + "°F");

             
                if (celsius < 0)
                {
                    Console.WriteLine("Warning: The temperature is below freezing (0°C)!");
                }
            }
            else
            {
         
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }

     
            Console.WriteLine("Press Enter to exit...");
            Console.ReadLine();
        }
    }
}
