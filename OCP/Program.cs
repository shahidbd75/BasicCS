using System;
using OCP.Solution;

namespace OCP
{
    class Program
    {
        static void Main(string[] args)
        {
            IReportGeneration crystalReportGeneration = new CrystalReportGeneration();

            crystalReportGeneration.GenerateReport("Habib");

            IReportGeneration pdfReportGeneration =new PdfReportGeneration();

            pdfReportGeneration.GenerateReport("Kamal");
        }
    }
}
