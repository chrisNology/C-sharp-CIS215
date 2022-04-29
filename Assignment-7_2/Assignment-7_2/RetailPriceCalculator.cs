using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_7_2
{
    class RetailPriceCalculator
    {
        static void Main(string[] args)
        {
            // Variable declaration
            double wholesale; // Wholesale cost
            double markup; // The markup percentage
            double itemPrice; // Item price

            // Wholesale input
            Console.WriteLine("Enter the wholesale value");
            wholesale = double.Parse(Console.ReadLine());

            // Markup input
            Console.WriteLine("Enter the markup percentage");
            markup = (double.Parse(Console.ReadLine()))/100;

            // Call the method
            itemPrice = calculateRetail(wholesale, markup);
            Console.WriteLine($"Item Retail Price: {itemPrice:C}");
            Console.ReadKey();

        } // End of main

        public static double calculateRetail(double wholesale, double markupPercent)
        {
            return wholesale + (wholesale * markupPercent);
        }
    } // End of class
} // End of namespace
