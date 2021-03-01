using System;
using System.Collections.Generic;
using System.Text;

namespace MidtermProject_POSApplication
{
    public class CreditCardPayment : IPayment
    {
        //public static CardNumber1 _cardNumber = new CardNumber1;
        //public static CardNumber1 CardNumberInstance
        //{
        //    get { return _cardNumber}
        //}


        public string CardNumber { get; set; }
        public string LastFourDigits { get; set; }
        public string ExpirationDate { get; set; }
        public string CVV { get; set; }

        public string PaymentType()
        {
            string paymentType = "credit";
            return paymentType;
        }

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
            //return LastFourDigits;
        }

        public string GetExpDate()
        {
            Console.Write("Expiration month: ");
            string expirationMonth = Console.ReadLine();
            int expMonth = Int32.Parse(expirationMonth);

            Console.Write("Expiration year: ");
            string expirationYear = Console.ReadLine();
            int expYear = Int32.Parse(expirationYear);

            string expirationdate = $"{expMonth}/{expYear}";
            ExpirationDate = expirationdate;
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

            Console.WriteLine($"hi {CardNumber}");
        }

        public void PrintReceiptInfo()
        {
            var receipt = new CreditCardPayment();


            Console.WriteLine(receipt.LastFourDigits);

        }
    }
}
