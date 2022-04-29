using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare Variables
            int aNo; // Account Number
            double bBal, charge, credit, cLimit; // Other Variables
            double newBal;            

            // Loop it
            int conti = 0; // Sentinal value is 1
            while (conti != 1) 
            {
                // Prompt for Account Number
                Console.Write("Enter Account Number: ");
                aNo = int.Parse(Console.ReadLine());

                // Prompt for Original Balance
                Console.Write("Enter Balance: ");
                bBal = Double.Parse(Console.ReadLine());

                // Prompt for Charges
                Console.Write("Enter Charges: ");
                charge = Double.Parse(Console.ReadLine());

                //Prompt for Credits
                Console.Write("Enter Credits: ");
                credit = Double.Parse(Console.ReadLine());

                // Prompt for Credit Limit
                Console.Write("Enter Credit Limit: ");
                cLimit = Double.Parse(Console.ReadLine());

                // Process the Input
                newBal = (bBal + charge) - credit;

                // Condition and Warning Display
                if (newBal > cLimit)
                {
                    Console.WriteLine("Credit limit exceeded");
                }

                // Display Balance
                Console.WriteLine($"New balance is: {newBal}");

                // Ask the user to continue
                Console.WriteLine("\nDo you want to enter another customer,");
                Console.WriteLine("Press any number other than 1 or 1 to exit ");
                conti = int.Parse(Console.ReadLine());

            } // End of Loop

            Console.ReadKey();

        } // End of Main
    }
}
