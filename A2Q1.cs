using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class A2Q1
    {
        public static void price ()
        {
            
            decimal[] itemPrices = { 1200.50m, 800.00m, 950.00m, 1500.75m, 450.25m };

            
            decimal totalPrice = 0;

            
            foreach (decimal price in itemPrices)
            {
                totalPrice += price;
            }

           
            if (totalPrice > 3000)
            {
                decimal discount = totalPrice * 0.10m;
                totalPrice -= discount;
                Console.WriteLine("A 10% discount has been applied.");
            }

            
            Console.WriteLine("The total price of items in the shopping cart is: Rs. " + totalPrice);

           
            Console.WriteLine("Press Enter to exit...");
            Console.ReadLine();
        }
    }
}
