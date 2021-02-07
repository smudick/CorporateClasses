using System;

namespace CorporateClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var Google = new Company("Google", new DateTime(1995, 1, 13));

            Google.Hire(new Employee("Sam"), "Full Stack Developer");
            Google.Hire(new Employee("Pepper"), "Chief Dog Officer");
            Google.Hire(new Employee("Creed"), "Quabbity Something");

            Google.GetEmployees();

            Google.Fire("Creed");

            Google.GetEmployees();
        }
    }
}
