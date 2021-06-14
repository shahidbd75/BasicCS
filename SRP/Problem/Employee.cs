using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP.Problem
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void InsertEmployee(Employee emp)
        {
            // Database Connection

            // INSERT into database

            // Send Notification

            Console.WriteLine("Employee inserted successfully");
        }

        public void GenerateReport(string reportType)
        {
            // Code For Report Generation
        }

        public void CalculateSalary(int employeeId)
        {
            // Code For Calculate Salary
        }
    }
}
