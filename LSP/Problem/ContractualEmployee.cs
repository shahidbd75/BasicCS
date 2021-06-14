namespace LSP.Problem
{
    public class ContractualEmployee: Employee
    {
        public ContractualEmployee(int id, string name, decimal salary) : base(id, name, salary)
        {
        }

        public override decimal CalculateSalary()
        {
            return this.Salary * 0.80m;
        }

        public override bool IsEligibleForBonus()
        {
            return true;
        }

        public override decimal CalculateBonus()
        {
            return this.Salary * 0.10m;
        }
    }
}
