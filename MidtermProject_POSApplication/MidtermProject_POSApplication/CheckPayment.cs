using System;
using System.Collections.Generic;
using System.Text;

namespace MidtermProject_POSApplication
{
    public class CheckPayment : IPayment
    {
        public string CheckNumber { get; set; }

        public void GetPaymentInformation()
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