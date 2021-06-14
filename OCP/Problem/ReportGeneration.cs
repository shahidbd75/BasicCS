using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.Problem
{
    public class ReportGeneration
    {
        public string ReportType { get; set; }

        /// <summary>
        /// What happens if new report type come??!!
        /// </summary>
        /// <param name="staffId"></param>
        public void GenerateReport(string staffId)
        {
            if (ReportType == "Pdf")
            {
                // Code For create pdf
            }

            if (ReportType == "Doc")
            {
                // Code For create doc
            }
        }
    }
}
