using System;

namespace LSP.Solution
{
    public class InternEmployee: Employee
    {
        public InternEmployee(int id, string name, decimal salary) : base(id, name, salary)
        {
        }

        public override decimal CalculateSalary()
        {
            return Salary;
        }

        public override bool IsEligibleForBonus()
        {
            return false;
        }

    }
}
