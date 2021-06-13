using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
    public class PermanentEmployee : Employee
    {
        public PermanentEmployee(int id, string name): base(id, name)
        {
        }
        public override decimal CalculateSalary(decimal salary)
        {
            return salary * 150;
        }

        public override bool IsEligibleForBonus()
        {
            return true;
        }
    }
}
