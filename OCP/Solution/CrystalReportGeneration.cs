using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.Solution
{
    public class CrystalReportGeneration: IReportGeneration
    {
        public string ReportType { get; set; }
        public void GenerateReport(string staffId)
        {
            Console.WriteLine("Generate Crystal Report");
        }
    }
}
