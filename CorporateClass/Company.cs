using System;
using System.Collections.Generic;
using System.Text;

namespace CorporateClass
{
    public class Company
    {
        // Some properties
        public string Name { get; }
        public DateTime CreatedOn { get; }

        // Create a private property for holding a collection of current employees
        List<string> Employees { get; set; } = new List<string>();
        // Create a method that allows a caller to add an employee
        public void Hire(string name)
        {
            Employees.Add(name);
        }
        // Create a method that allows a caller to remove an employee
        public void Fire(string name)
        {
            if (Employees.Contains(name))
            {
                Employees.Remove(name);
            }
            else
            {
                Console.WriteLine($"{name} doesn't even work here");
            }
        }
        // Create a method that allows a caller to retrieve the list of employees

        public void GetEmployees()
        {
            Console.WriteLine($"{Name} employee roster\n-------------------");
            foreach (var employee in Employees)
            {
                Console.WriteLine(employee);
            }
            Console.WriteLine("-------------------\n");
        }

        /*
            Create a constructor method that accepts two arguments:
                1. The name of the company
                2. The date it was created

            The constructor will set the value of the public properties
        */
        public Company(string name, DateTime createdOn)
        {
            Name = name;
            CreatedOn = createdOn;
        }
    }
}
