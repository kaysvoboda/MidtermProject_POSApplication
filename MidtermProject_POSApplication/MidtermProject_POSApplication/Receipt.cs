using System;
using System.Collections.Generic;
using System.Text;

namespace MidtermProject_POSApplication
{
    public class Receipt
    {
        public void PrintReceipt()
        {
            GetPayment getPayment = new GetPayment();
            string paymentChoice = getPayment.GetPaymentType();

            GetPayment payment = new GetPayment();
            //payment.ReturnPaymentType(paymentChoice);
            Console.WriteLine(payment.ReturnPaymentType(paymentChoice)); //for test


        }

    }
}
