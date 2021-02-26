using System;
using System.Collections.Generic;
using System.Text;

namespace MidtermProject_POSApplication
{
    public class CashPayment : Payment
    {

        public decimal AmountTendered { get; set; }

        public decimal ProvideChange(decimal amountTendered, decimal total) 

        public override PMT PaymentType()
        {
            PMT paymentType= PMT.Cash;
            return paymentType;
        }
        public double AmountTendered { get; set; }
        public double ChangeOwed { get; set; }

        public double GetCashPayment()

        {
            Console.Write("Amount tendered: ");
            string tendered = Console.ReadLine();
            double amountTendered = Double.Parse(tendered);
            AmountTendered = amountTendered;

            decimal change = amountTendered - total;
            

            return AmountTendered;

        }

        public double ProvideChange(double amountTendered, double total) 
        {
            double changeOwed = amountTendered - total;
            ChangeOwed = changeOwed;
            return ChangeOwed;
        }

        public void GetPaymentInformation()
        {
            var payment = new CashPayment();
            var total = new Math();
            var grandTotal = total.FindGrandTotal(total.FindtaxTotal(total.FindSumTotal(14)), total.FindSumTotal(14)); //need to update to take in subtotal once list logic is built
         
            payment.GetCashPayment();
            //Console.WriteLine($"Amount Tendered: {AmountTendered}");
            //Console.WriteLine($"Change due: {payment.ProvideChange(AmountTendered, grandTotal)}");


        }

    }
}
