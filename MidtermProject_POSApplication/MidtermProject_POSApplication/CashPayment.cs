using System;
using System.Collections.Generic;
using System.Text;

namespace MidtermProject_POSApplication
{
    public class CashPayment : IPayment
    {


        public decimal AmountTendered { get; set; }
        public decimal ChangeOwed { get; set; }


        public string PaymentType()
        {
            string paymentType = "cash";
            return paymentType;
        }

        public void GetPaymentInformation()
        {
            bool cashVerification = false;
            decimal AmountTendered = 0;

            Console.Write("Amount tendered: ");
            string tendered = Console.ReadLine();
            int amountTendered;
            bool validCash = int.TryParse(Console.ReadLine(), out amountTendered); 
            if (!validCash)
            {
                cashVerification = false;
                Console.WriteLine("invalid entry- please choose a number between 1 and 100");
            }
            else
            {
                cashVerification = true;
            }
            AmountTendered = amountTendered;

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