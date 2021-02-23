using System;
using System.Collections.Generic;
using System.Text;

namespace MidtermProject_POSApplication
{
    public class CashPayment : IPayment
    {
        public double AmountTendered { get; set; }

        public double ProvideChange(double amountTendered, double total) 
        {
            AmountTendered = amountTendered;
            double change = amountTendered - total;
            return change;
        }

    }
}
