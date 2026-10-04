using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjectsAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the Employee class
            Employee employee = new Employee();
            employee.FirstName = "Sample";
            employee.LastName = "Student";

            // Call the SayName method on the Employee object
            employee.SayName();

            // Wait for user input before closing the console window
            Console.ReadLine();
        }
    }
}
