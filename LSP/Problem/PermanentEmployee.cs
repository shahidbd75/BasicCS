namespace LSP.Problem
{
    public class PermanentEmployee : Employee
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

        public override decimal CalculateBonus()
        {
           return this.Salary * 0.33m;
        }
    }
}
