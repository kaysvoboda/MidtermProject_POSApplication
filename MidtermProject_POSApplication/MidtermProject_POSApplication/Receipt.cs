using System;
using System.Collections.Generic;
using System.Text;

namespace MidtermProject_POSApplication
{
    public class Receipt
    {
        public void PrintReceipt()
        {
            //move below to method within Math Class maybe?
            var paymentDue = new Math();
            Console.WriteLine($"Subtotal: ${paymentDue.FindSumTotal(15)}"); //update intake
            Console.WriteLine($"Tax: ${paymentDue.FindtaxTotal(paymentDue.SumTotal)}");
            Console.WriteLine($"Amount Due: ${paymentDue.FindGrandTotal(paymentDue.TaxTotal, paymentDue.SumTotal)}");
            Console.WriteLine("-------------------");

            GetPayment getPayment = new GetPayment();
            getPayment.GetPaymentType();
            getPayment.ReturnPaymentType(getPayment.PaymentMethod);


            Console.WriteLine("-------------------");
            getPayment.CreateReceipt(getPayment.PaymentMethod);
            







        }

    }
}
