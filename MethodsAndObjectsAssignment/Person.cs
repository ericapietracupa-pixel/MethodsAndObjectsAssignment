using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjectsAssignment
{
    internal class Person
    {
        // Properties for the first name and last name of the person
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Method to display the full name of the person
        public void SayName()
        {
            Console.WriteLine($"Name: {FirstName} {LastName}");
        }
    }
}
