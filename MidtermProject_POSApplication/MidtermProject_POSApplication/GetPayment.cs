using System;
using System.Collections.Generic;
using System.Text;
using static System.Environment;

namespace MidtermProject_POSApplication
{
    public class GetPayment
    {

        public string PaymentMethod { get; set; }
        public string DisplayCardNumber { get; set; }
        public double AmountTendered { get; set; }
        public string ChangeDue { get; set; }
        public string CheckNumber { get; set; }


        public string GetPaymentType()
        {
            while (true)
            {
                Console.WriteLine("How would you like to pay today? Credit, cash, or check?: ");
                string paymentMethod = Console.ReadLine();
                PaymentMethod = paymentMethod;
                if ((paymentMethod.ToLower() != "credit" && paymentMethod.ToLower() != "cash" && paymentMethod.ToLower() != "check"))
                {
                    Console.WriteLine("Sorry, that payment type is invalid. Please choose credit, cash, or check.");
                }
                else return PaymentMethod;
            }
        }

        public string ReturnPaymentType(string paymentMethod, double subTotal)
        {
            
            if (paymentMethod.ToLower() == "credit")
            {

                var payment = new CreditCardPayment();
                payment.GetCardNumber();
                payment.GetExpDate();
                payment.GetCVV();
                payment.ObscureCCNumber(payment.CardNumber);
                string display = payment.LastFourDigits;
                DisplayCardNumber = display;
                return DisplayCardNumber;

            }
            else if (paymentMethod.ToLower() == "cash")
            {
                var payment = new CashPayment();
                var total = new Math();

                payment.GetPaymentInformation();
                AmountTendered = payment.AmountTendered;
                double changeDue = payment.ProvideChange(AmountTendered, (double)total.FindGrandTotal(total.FindtaxTotal(subTotal),subTotal));
                ChangeDue = $"${changeDue:#.##}";
                return ChangeDue;


            }
            else if (paymentMethod.ToLower() == "check")
            {
                var payment = new CheckPayment();
                payment.GetPaymentInformation();
                var checkNumber = payment.CheckNumber;
                CheckNumber = checkNumber;
                return CheckNumber;

            }
            else throw new Exception(nameof(paymentMethod));
        }
        public string CreateReceipt(string paymentMethod)
        {
            
            if (paymentMethod.ToLower() == "credit")
            {   
                Console.WriteLine($"Payment Type: Credit" +NewLine+
                $"Card Number: {DisplayCardNumber}" +NewLine+
                $"Payment: APPROVED");
                return "credit";
            }
            else if (paymentMethod.ToLower() == "cash")
            {
                Console.WriteLine("Payment Type: Cash");
                Console.WriteLine($"Amount Tendered: ${AmountTendered.ToString("0.00")}");
                Console.WriteLine($"Change Due: {ChangeDue}");
                return "cash";
            }
            else if (paymentMethod.ToLower() == "check")
            {
                Console.WriteLine("Payment Type: Check");
                Console.WriteLine($"Check Number: {CheckNumber}");

                    return "check";
            }
            else throw new Exception(nameof(paymentMethod));
        }

    }


}

