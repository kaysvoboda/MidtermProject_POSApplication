using System;
using System.Collections.Generic;
using System.Text;

namespace MidtermProject_POSApplication
{
    public class CashPayment : IPayment
    {


        public decimal AmountTendered { get; set; }

        public decimal ProvideChange(decimal amountTendered, decimal total) 



        public string PaymentType()

        {
            string paymentType = "cash";
            return paymentType;
        }
        public decimal AmountTendered { get; set; }
        public decimal ChangeOwed { get; set; }


        public double GetCashPayment()




        public void GetPaymentInformation()

        {
            Console.Write("Amount tendered: ");
            string tendered = Console.ReadLine();
            decimal amountTendered = decimal.Parse(tendered);
            AmountTendered = amountTendered;


            decimal change = amountTendered - total;
            

            return AmountTendered;

            //return AmountTendered;

        }

        public decimal ProvideChange(decimal amountTendered, decimal total) 
        {
            decimal changeOwed = amountTendered - total;
            ChangeOwed = changeOwed;
            return ChangeOwed;
        }

        public void PrintReceiptInfo()
        {
            var payment = new CashPayment();
            var total = new Math();
            payment.GetPaymentInformation();
            payment.ProvideChange(AmountTendered, (decimal)(total.FindGrandTotal(total.FindtaxTotal(15), total.FindSumTotal(15))));

         
            Console.WriteLine($"Amount Tendered: {AmountTendered}");
            Console.WriteLine($"Change due: {ChangeOwed}");



        }

    }
}
