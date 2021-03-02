using System;
using System.Collections.Generic;
using System.Text;

namespace MidtermProject_POSApplication
{
    public class CheckPayment : IPayment
    {
        public string PaymentType()
        {
            string paymentType = "Check";
            return paymentType;
        }

        public string CheckNumber { get; set; }

        public void GetPaymentInformation() //testing - may need to ad different method with this name
        {
            Console.Write("Check number: ");
            string checkNumber = Console.ReadLine();
            CheckNumber = checkNumber;

        }

        public void PrintReceiptInfo()
        {
            Console.WriteLine("Payment Method: Check");
            Console.WriteLine($"Check Number: {CheckNumber}");
        }

    }
}
