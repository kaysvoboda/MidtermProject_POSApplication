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
        public string ChangeDue { get; set; }
        public string CheckNumber { get; set; }


        public string GetPaymentType()
        {
            while (true)
            {
                Console.WriteLine("Would you like to pay with credit, cash, or check?: ");
                string paymentMethod = Console.ReadLine();
                PaymentMethod = paymentMethod;
                if ((paymentMethod.ToLower() != "credit" && paymentMethod.ToLower() != "cash" && paymentMethod.ToLower() != "check"))
                {
                    Console.WriteLine("Invalid payment type. Please user credit, cash, or check");
                }
                else return PaymentMethod;
            }
        }

        public string ReturnPaymentType(string paymentMethod)
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
                
                payment.GetPaymentInformation();
                decimal changeDue = payment.ProvideChange(payment.AmountTendered, 15); //update '15' once class is available to call
                ChangeDue = $"${changeDue:#.##}";
                return ChangeDue;


            }
            else if (paymentMethod.ToLower() == "check")
            {
                var payment = new CheckPayment();
                var checknumber = 
                    payment.PaymentType();
                CheckNumber = checknumber;
                return CheckNumber;

            }
            else throw new Exception(nameof(paymentMethod));
        }
        public string CreateReceipt(string paymentMethod)
        {
            var cashPayment = new CashPayment();


            if (paymentMethod.ToLower() == "credit")
            {   return $"Payment Type: Credit" +NewLine+
                $"Card Number: {DisplayCardNumber}" +NewLine+
                $"Payment: APPROVED";
            }
            else if (paymentMethod.ToLower() == "cash")
            {
                Console.WriteLine("Payment Type: Cash");
                Console.WriteLine($"Amount Tendered: {cashPayment.AmountTendered}");
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



        //string display =


        // return $"Payment Type: Credit" + NewLine +
        // $"Card Number {display} : Approved" + NewLine +
        //                 $"Change Due: $0";

        //return $"Payment Type: Cash" + NewLine +
        //$"Total:" + NewLine + //update to add {total} once available
        //$"Amount tendered: {payment.AmountTendered}" + NewLine +
        //$"Change due: {payment.ChangeOwed}";

    }


}

