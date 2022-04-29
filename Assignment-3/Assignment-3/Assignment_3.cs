using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// C-sharp is an object oriented language
// A class has a main method known as an executable class
namespace Assignment_3
{
    class Program //This is an executable class means you can run it
    {
        static void Main(string[] args)
        {
            // Input
            double height, weight, bmi;
            // USER Input
            Console.WriteLine("Enter Weight in Inches");
            // Parse is a method which is used to convert
            weight = Double.Parse(Console.ReadLine()); // Data conversion

            Console.WriteLine("Enter Height in Inches");
            height = Double.Parse(Console.ReadLine()); // Data conversion

            // Process
            bmi = (weight * 703) / (height * height);

            // Display
            Console.WriteLine($"BMI IS :{bmi}");
            // To stop
            Console.ReadKey();
        }
    }
}
