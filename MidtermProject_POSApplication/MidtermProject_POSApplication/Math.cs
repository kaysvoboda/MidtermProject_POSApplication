using System;
using System.Collections.Generic;
using System.Text;


namespace MidtermProject_POSApplication
{
    public class Math
    {
        public double SumTotal { get; set; }
        public double TaxTotal { get; set; }
        public double GrandTotal { get; set; }

        public double FindtaxTotal(double sumTotal)
        {
            double taxTotal = sumTotal * .06;
            TaxTotal = taxTotal;
            return TaxTotal;
        }

        public double FindGrandTotal(double taxTotal, double sumTotal)
        {
            double grandTotal = sumTotal + taxTotal;
            GrandTotal = grandTotal;
            return GrandTotal;
        }
    }
}