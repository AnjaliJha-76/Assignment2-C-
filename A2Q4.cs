using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class A2Q4
    {
        public static void mark()
        {
        
            int[] marks = new int[5];
            int totalMarks = 0;

        
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Enter the marks for subject {i + 1}: ");
                string input = Console.ReadLine();

              
                int mark;
                if (int.TryParse(input, out mark) && mark >= 0 && mark <= 100)
                {
                    marks[i] = mark;
                    totalMarks += mark;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number between 0 and 100.");
                    i--;
                }
            }

        
            double average = totalMarks / 5.0;

         
            char grade;
            if (average >= 90)
            {
                grade = 'A';
            }
            else if (average >= 80)
            {
                grade = 'B';
            }
            else if (average >= 70)
            {
                grade = 'C';
            }
            else if (average >= 60)
            {
                grade = 'D';
            }
            else
            {
                grade = 'F';
            }

         
            Console.WriteLine($"The average mark is: {average}");
            Console.WriteLine($"The grade is: {grade}");

        
            Console.WriteLine("Press Enter to exit...");
            Console.ReadLine();
        }
    }
}
