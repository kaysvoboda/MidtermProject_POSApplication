using System;
using System.Collections.Generic;
using System.Text;


namespace midterm_scratch
{
    public class Math : PriceList
    {
        public double SumTotal { get; set; }
        public double TaxTotal { get; set; }
        public double GrandTotal { get; set; }


        public double FindSumTotal(double sumTotal)
        {
            PriceList priceList = new PriceList();
            List<double> practice = priceList.addToList();
            for(int i = 0; i < practice.Count; i++) // need list name
                {
                double sum = 0;
                sumTotal = sum + i;
                }

            SumTotal = sumTotal;
            return SumTotal;
        }

        public double FindtaxTotal(double sumTotal)
        {
            
            double taxTotal = sumTotal * 0.06;
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