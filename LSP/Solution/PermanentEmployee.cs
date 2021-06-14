namespace LSP.Solution
{
    public class PermanentEmployee : Employee,IBonus
    {
        public PermanentEmployee(int id, string name, decimal salary): base(id, name, salary)
        {
        }
        public override decimal CalculateSalary()
        {
            return this.Salary * 1.5m;
        }

        public override bool IsEligibleForBonus()
        {
            return true;
        }

        public decimal CalculateBonus()
        {
           return this.Salary * 0.33m;
        }
    }
}
