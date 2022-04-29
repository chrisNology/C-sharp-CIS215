using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assignment_3_ComparingInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input
            int num1, num2;
            Console.WriteLine("Enter First Number");
            // Data Conversion
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Second Number");
            // Data Conversion
            num2 = int.Parse(Console.ReadLine());

            // Process Condition Statements
            if (num1 > num2)
            {
                Console.WriteLine("Number 1 is larger than number 2");
            }

            if (num1 < num2) // Boolean, answer True or False
            {
                Console.WriteLine("Number 1 is less than number 2");
            }

            if (num1 == num2) // == means equal to
            {
                Console.WriteLine("Number 1 is equal to number 2");
            }

            Console.ReadKey(); // Stop the screen

        }
    } // End of class
} // End of namespace
