using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4_11
{
    class EmployeeTest
    {
        static void Main(string[] args)
        {
            // Create Employer 1 Object
            Employee emp1 = new Employee("Susan", "Crouse", 250000);

            decimal emp1Salary = emp1.MSal;
            decimal raise = 1.10M;
            decimal raiseSal1 = emp1Salary * raise;
            Console.WriteLine("Employee 1");
            Console.WriteLine("------------------");
            Console.WriteLine($"First Name: {emp1.FName}");
            Console.WriteLine($"Last Name: {emp1.LName}");
            Console.WriteLine($"Salary: {emp1.MSal:C}");
            Console.WriteLine($"Raise: {raiseSal1:C}");
            Console.WriteLine("------------------");
            
            Console.WriteLine("\n");

            // Create Employer 2 Object
            Employee emp2 = new Employee("John", "Scenery", 175000);

            decimal emp2Salary = emp2.MSal;
            decimal raiseSal2 = emp2Salary * raise;
            Console.WriteLine("Employee 2");
            Console.WriteLine("------------------");
            Console.WriteLine($"First Name: {emp2.FName}");
            Console.WriteLine($"Last Name: {emp2.LName}");
            Console.WriteLine($"Salary: {emp2.MSal:C}");
            Console.WriteLine($"Raise: {raiseSal2:C}");
            Console.WriteLine("------------------");



            Console.ReadKey(); // Pause screen
        }
    }
}
