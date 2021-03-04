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
            Console.Write("Amount tendered: ");
            string tendered = Console.ReadLine();
            bool validCash = double.TryParse(tendered, out double amountTendered);
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
    }
}