using System;
using System.Collections.Generic;
using System.Text;

namespace MidtermProject_POSApplication
{
    public class CashPayment : IPayment
    {
        public double AmountTendered { get; set; }
        public double ChangeOwed { get; set; }

        public double GetCashPayment()
        {
            Console.Write("Amount tendered: ");
            string tendered = Console.ReadLine();
            double amountTendered = Double.Parse(tendered);
            AmountTendered = amountTendered;
            return AmountTendered;

        }

        public double ProvideChange(double amountTendered, double total) 
        {
            //AmountTendered = amountTendered;
            double changeOwed = amountTendered - total;
            ChangeOwed = changeOwed;
            return ChangeOwed;
        }

    }
}
