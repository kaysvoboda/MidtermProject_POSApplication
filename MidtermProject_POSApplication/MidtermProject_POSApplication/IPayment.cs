using System;
using System.Collections.Generic;
using System.Text;

namespace MidtermProject_POSApplication
{
    public interface IPayment
    {
        string PaymentType();

        public decimal GetPaymentInformation();

        public void PrintReceiptInfo();
    }
}
