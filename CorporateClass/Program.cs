using System;

namespace CorporateClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var Google = new Company("Google", new DateTime(1995, 1, 13));

            Google.Hire("Sam");
            Google.Hire("Kaitlyn");
            Google.Hire("Dana");
            Google.Hire("Bob the worst employee ever");

            Google.GetEmployees();

            Google.Fire("Bob the worst employee ever");
            Google.GetEmployees();
        }
    }
}
