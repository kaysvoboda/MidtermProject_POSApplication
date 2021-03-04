using System;
using System.Collections.Generic;
using System.Text;

namespace MidtermProject_POSApplication
{
    public class CreditCardPayment : IPayment
    {
        public string CardNumber { get; set; }
        public string LastFourDigits { get; set; }
        public string ExpirationDate { get; set; }
        public string CVV { get; set; }


        public string GetCardNumber()
        {
            Console.Write("Card number: ");
            string cardnumber = Console.ReadLine();
            CardNumber = cardnumber;
            return CardNumber;
        }

        public void ObscureCCNumber(string cardNumber)
        {
            string lastFourDigits = $"XXXX XXXX XXXX {cardNumber.Substring(cardNumber.Length - 4)}";
            LastFourDigits = lastFourDigits;
        }

        public string GetExpDate()
        {
            Console.Write("Expiration date: ");
            string expirationDate = Console.ReadLine();
            ExpirationDate = expirationDate;
            return ExpirationDate;
        }

        public string GetCVV()
        {
            Console.Write("CVV: ");
            string inputCVV = Console.ReadLine();
            CVV = inputCVV;
            return CVV;
        }

        public void GetPaymentInformation()
        {
            var payment = new CreditCardPayment();
            string cardNumber = payment.GetCardNumber();
            CardNumber = cardNumber;
            payment.GetExpDate();
            payment.GetCVV();
            string lastFourDigits = $"XXXX XXXX XXXX {cardNumber.Substring(cardNumber.Length - 4)}";
            LastFourDigits = lastFourDigits;
        }

        public void PrintReceiptInfo()
        {
            Console.WriteLine("Payment Type: Credit Card");
            Console.WriteLine($"Card Number: {LastFourDigits}");
            Console.WriteLine("Card Payment : APPROVED");
        }
    }
}
