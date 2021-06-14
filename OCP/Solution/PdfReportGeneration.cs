using System;

namespace OCP.Solution
{
    public class PdfReportGeneration: IReportGeneration
    {
        public string ReportType { get; set; }

        /// <summary>
        /// Code For Pdf Generation
        /// </summary>
        /// <param name="staffId"></param>
        public void GenerateReport(string staffId)
        {
            Console.WriteLine("Generate Pdf Report");
        }
    }
}
