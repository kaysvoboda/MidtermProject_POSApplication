using System;
using System.Collections.Generic;
using System.Text;
using static System.Environment;

namespace MidtermProject_POSApplication
{
    public class GetPayment
    {
        public string GetPaymentType()
        {
            while (true)
            {
                Console.WriteLine("Would you like to pay with credit, cash, or check?: ");
                string userInput = Console.ReadLine();
                if ((userInput.ToLower() != "credit" && userInput.ToLower() != "cash" && userInput.ToLower() != "check"))
                {
                    Console.WriteLine("Invalid payment type. Please user credit, cash, or check");
                }
                else return userInput;
            }
        }

        public string ReturnPaymentType(string userInput)
        {
            //Payment paymentCredit = new CreditCardPayment();
            //Payment paymentCash = new CashPayment();
            //Payment paymentCheck = new CheckPayment();


            if (userInput.ToLower() == "credit")
            {

                var payment = new CreditCardPayment();
                payment.GetCardNumber();
                payment.GetExpDate();
                payment.GetCVV();
                payment.ObscureCCNumber(payment.CardNumber);
                string display = payment.LastFourDigits;


                return $"Payment Type: Credit" + NewLine +
                       $"Card Number {display} : Approved" + NewLine +
                        $"Change Due: $0";
            }
            else if (userInput.ToLower() == "cash")
            {
                var payment = new CashPayment();
                payment.GetCashPayment();
                payment.ProvideChange(payment.AmountTendered, 15); //update '15' once class is available to call


                return $"Payment Type: Cash" + NewLine +
                       $"Total:" + NewLine + //update to add {total} once available
                       $"Amount tendered: {payment.AmountTendered}" + NewLine +
                       $"Change due: {payment.ChangeOwed}";
            }
            else if (userInput.ToLower() == "check")
            {
                var payment = new CheckPayment();
                payment.GetCheckNumber();
                return $"Payment Type: Check" + NewLine +
                        $"Change Due: $0";

            }
            else throw new Exception(nameof(userInput));
        }
        public void CreateReceipt()
        {

        }
        


    }
}
