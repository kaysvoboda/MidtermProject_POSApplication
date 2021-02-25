using System;
using System.Collections.Generic;
using System.Text;

namespace MidtermProject_POSApplication
{
    public class CheckPayment : Payment
    {
        public override PMT PaymentType()
        {
            PMT paymentType = PMT.Check;
            return paymentType;
        }

        public string CheckNumber { get; set; }

        public string GetCheckNumber()
        {
            Console.Write("Check number: ");
            string checkNumber = Console.ReadLine();
            CheckNumber = checkNumber;
            return CheckNumber;

        }

        public void GetPaymentInformation()
        {
            var payment = new CheckPayment();
            payment.GetCheckNumber();
        }

    }


}
