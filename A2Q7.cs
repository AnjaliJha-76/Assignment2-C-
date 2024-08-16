using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class A2Q7
    {
        public static void attendance()
        {
            const int totalDays = 5;
            bool[] attendance = new bool[totalDays];

         
            for (int i = 0; i < totalDays; i++)
            {
                Console.Write($"Enter attendance for day {i + 1} (P for present, A for absent): ");
                char input = Console.ReadKey().KeyChar;
                Console.WriteLine(); 

              
                input = char.ToUpper(input);

              
                if (input == 'P')
                {
                    attendance[i] = true; 
                }
                else if (input == 'A')
                {
                    attendance[i] = false;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter 'P' for present or 'A' for absent.");
                    i--;
                }
            }

         
            int daysAttended = 0;
            foreach (bool present in attendance)
            {
                if (present)
                {
                    daysAttended++;
                }
            }

            
            Console.WriteLine($"\nTotal number of days attended: {daysAttended}");

            
            if (daysAttended == totalDays)
            {
                Console.WriteLine("The student has perfect attendance!");
            }
            else
            {
                Console.WriteLine("The student does not have perfect attendance.");
            }

            
            Console.WriteLine("\nPress Enter to exit...");
            Console.ReadLine();
        }
    }
}