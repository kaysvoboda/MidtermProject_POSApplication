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

            double amountTendered = double.Parse(tendered);
            AmountTendered = amountTendered;
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
            payment.ProvideChange(AmountTendered, (double)(total.FindGrandTotal(total.FindtaxTotal(15),15)));


            Console.WriteLine($"Amount Tendered: {AmountTendered}");
            Console.WriteLine($"Change due: {ChangeOwed}");
        }

    }
}