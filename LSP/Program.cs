using System;
using System.Collections.Generic;
using LSP.Problem;

namespace LSP
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>
            {
                new PermanentEmployee(1,"M.Zaman",1000),
                new ContractualEmployee(2,"Zunaid",500),
                new InternEmployee(3,"Hasin",200)
            };

            foreach (var employee in employees)
            {
                Console.WriteLine(employee.Name);
                Console.WriteLine(employee.IsEligibleForBonus());
                Console.WriteLine(employee.CalculateBonus()); // Throw exception for Intern employee. That's violet LSP
                Console.WriteLine("===========");
            }
        }
    }
}
