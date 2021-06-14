namespace LSP.Solution
{
    public class ContractualEmployee: Employee,IBonus
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

        public decimal CalculateBonus()
        {
            return this.Salary * 0.10m;
        }
    }
}
