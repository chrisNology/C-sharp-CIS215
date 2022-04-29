using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    class InvoiceTest
    {
        static void Main(string[] args)
        {
            // Create an object of Invoice class
            Invoice v1 = new Invoice("12","Tool",2,2.34);
            Console.WriteLine($"Part Number: { v1.PartNumber}");
            Console.WriteLine($"Part Description: { v1.PartDesc}");
            Console.WriteLine($"Part Item: { v1.PItem:C}");

            Console.ReadKey(); // Pause screen

        }
    }
}
