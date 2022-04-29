using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_7_8
{
    class Garage
    {
        static void Main(string[] args)
        {

            // Varialbles
            double totalReceipts = 0; // Total fee collected for the day
            double fee, hours; // The charge for the current customer

            // User Input
            Console.Write("Enter number of hours (a negative or zero to quit): ");
            hours = double.Parse(Console.ReadLine());

            // Loop if hours greater than 0
            while (hours > 0.0)
            {
                // Calculate and display charges
                fee = CalculateCharges(hours);
                totalReceipts += fee;
                Console.WriteLine($"Current charge: {fee:C}, Total receipts: {totalReceipts:C}");                

                // Input the next customer's hours
                Console.Write("Enter number of hours (a negative or zero to quit): ");
                hours = double.Parse(Console.ReadLine());
            }

            // Call method

        } // End of main

        public static double CalculateCharges(double hours)
        {
            // Calculate charges
            double charge = 2.0;

            // Add fees if any
            if (hours > 3.0)
            {
                charge = charge + (double)(0.5 * Math.Ceiling(hours - 3.0));
            }

            // Add max value if any
            if (charge > 10)
            {
                charge = 10;
            }
            return charge;
        }
    } // End of class
} // End of namespace
