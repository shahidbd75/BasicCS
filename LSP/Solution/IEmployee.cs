﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.Solution
{
    public interface IEmployee
    {
        decimal CalculateSalary();
        bool IsEligibleForBonus();
    }
}
