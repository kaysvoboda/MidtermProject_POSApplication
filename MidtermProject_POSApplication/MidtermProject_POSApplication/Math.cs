using System;
using System.Collections.Generic;
using System.Text;


namespace MidtermProject_POSApplication
{
    public class Math : PriceList
    {
        public decimal SumTotal { get; set; }
        public decimal TaxTotal { get; set; }
        public decimal GrandTotal { get; set; }


        public decimal FindSumTotal(decimal sumTotal)
        {
            //PriceList priceList = new PriceList();
            //List<double> practice = priceList.addToList();
            //for(int i = 0; i < practice.Count; i++) // need list name
            //    {
            //    double sum = 0;
            //    sumTotal = sum + i;
            //    }

            SumTotal = sumTotal;
            return SumTotal;
        }

        public decimal FindtaxTotal(decimal sumTotal)
        {

            decimal taxTotal = sumTotal * .06M;
            TaxTotal = taxTotal;
            return TaxTotal;
        }

        public decimal FindGrandTotal(decimal taxTotal, decimal sumTotal)
        {
            decimal grandTotal = sumTotal + taxTotal;
            GrandTotal = grandTotal;
            return GrandTotal;
        }
    }
}