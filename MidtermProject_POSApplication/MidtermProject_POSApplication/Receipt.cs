using System;
using System.Collections.Generic;
using System.Text;

namespace MidtermProject_POSApplication
{
    public class Receipt
    {
        public void PrintReceipt()
        {

            var paymentDue = new Math();
            Console.WriteLine($"Subtotal: ${paymentDue.FindSumTotal(50)}"); //update intake
            Console.WriteLine($"Tax: ${paymentDue.FindtaxTotal(paymentDue.SumTotal)}");
            Console.WriteLine($"Amount Due: ${paymentDue.FindGrandTotal(paymentDue.TaxTotal, paymentDue.SumTotal)}");

            GetPayment getPayment = new GetPayment();
            string paymentChoice = getPayment.GetPaymentType();

            GetPayment payment = new GetPayment();
            Console.WriteLine(payment.ReturnPaymentType(paymentChoice)); 

        }

    }
}
