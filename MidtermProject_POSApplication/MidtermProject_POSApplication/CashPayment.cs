using System;
using System.Collections.Generic;
using System.Text;

namespace MidtermProject_POSApplication
{
    public class CashPayment : IPayment
    {
        public double AmountTendered { get; set; }
        public double ChangeOwed { get; set; }



        public string PaymentType()
        {
            string paymentType = "cash";
            return paymentType;
        }


        public void GetPaymentInformation()
        {
            bool cashVerification = false;

            Console.Write("Amount tendered: ");
            string tendered = Console.ReadLine();
            double amountTendered;

            bool validCash = double.TryParse(tendered, out amountTendered);
            if (validCash == false)
            {

                Console.WriteLine("Invalid entry.");
            }
            else
            {
                AmountTendered = amountTendered;
            }
        }

        public double ProvideChange(double amountTendered, double total)
        {
            double changeOwed = amountTendered - total;
            ChangeOwed = changeOwed;
            return ChangeOwed;
        }

        public void PrintReceiptInfo()
        {
            var payment = new CashPayment();
            var total = new Math();
            payment.ProvideChange(AmountTendered, (double)(total.FindGrandTotal(total.FindtaxTotal(15), 15)));


            Console.WriteLine($"Amount Tendered: {AmountTendered}");
            Console.WriteLine($"Change due: {ChangeOwed}");
        }

    }
}