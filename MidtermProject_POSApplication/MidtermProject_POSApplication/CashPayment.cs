using System;
using System.Collections.Generic;
using System.Text;

namespace MidtermProject_POSApplication
{
    public class CashPayment : IPayment
    {
        public string PaymentType()
        {
            string paymentType = "cash";
            return paymentType;
        }


        public decimal AmountTendered { get; set; }
        public decimal ChangeOwed { get; set; }

        //public static decimal amountTendered = 0.0M;


        public void GetPaymentInformation()
        {
            Console.Write("Amount tendered: ");
            string tendered = Console.ReadLine();
            decimal amountTendered = decimal.Parse(tendered);
            AmountTendered = amountTendered;
            //return AmountTendered;
        }


        public decimal ProvideChange(decimal amountTendered, decimal total) 
        {

            decimal _changeOwed = amountTendered - total;
            ChangeOwed = _changeOwed;
            return ChangeOwed;
        }

        public void PrintReceiptInfo()
        {           
            var total = new Math();
            ProvideChange(AmountTendered, (decimal)total.FindGrandTotal(total.FindtaxTotal(15.0M), total.FindSumTotal(15.0M)));

         
            Console.WriteLine($"Amount Tendered: ${AmountTendered}");
            Console.WriteLine($"Change due: ${ChangeOwed.ToString("0.00")}");


        }

    }
}
