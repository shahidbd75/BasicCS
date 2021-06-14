namespace LSP.Solution
{
    public abstract class Employee: IEmployee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }

        protected Employee(int id, string name, decimal salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }
        

        public abstract decimal CalculateSalary();

        public abstract bool IsEligibleForBonus();
    }
}
