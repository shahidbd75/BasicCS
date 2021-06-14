using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.Solution
{
    interface IReportGeneration
    {
        string ReportType { get; set; }

        void GenerateReport(string staffId);
    }
}
