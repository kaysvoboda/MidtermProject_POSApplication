using System;
using System.Collections.Generic;
using System.Text;

namespace MidtermProject_POSApplication
{
    class CreditCardPayment : IPayment 
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

        public string ObscureCCNumber(string cardnumber)
        {
            string lastFourDigits = $"XXXX XXXX XXXX {cardnumber.Substring(cardnumber.Length - 4)}";
            LastFourDigits = lastFourDigits;
            return LastFourDigits;
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
    }
}
