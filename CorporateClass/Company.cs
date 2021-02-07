using System;
using System.Collections.Generic;
using System.Linq;

namespace CorporateClass
{
    public class Company
    {
        // Some properties
        public string Name { get; }
        public DateTime CreatedOn { get; }

        // Create a private property for holding a collection of current employees
        List<Employee> EmployeeList { get; set; } = new List<Employee>();
        // Create a method that allows a caller to add an employee
        public void Hire(Employee newEmployee, string title)
        {
            EmployeeList.Add(newEmployee);
            newEmployee.Title = title;
            newEmployee.StartDate = DateTime.Now;

        }
        // Create a method that allows a caller to remove an employee
        public void Fire(string name)
        {
            EmployeeList.Remove(EmployeeList.First(employee => employee.Name == name));
        }
        // Create a method that allows a caller to retrieve the list of employees

        public void GetEmployees()
        {
            Console.WriteLine($"{Name} employee roster\n-------------------");
            foreach (var employee in EmployeeList)
            {
                Console.WriteLine($"{employee.Name} | {employee.Title} | Hire Date: {employee.StartDate}");
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
