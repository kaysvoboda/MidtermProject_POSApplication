using System;
using System.Collections.Generic;
using System.Text;

namespace MidtermProject_POSApplication
{
    public class CashPayment : IPayment
    {
        public decimal AmountTendered { get; set; }

        public decimal ProvideChange(decimal amountTendered, decimal total) 
        {
            AmountTendered = amountTendered;
            decimal change = amountTendered - total;
            return change;
        }

    }
}
