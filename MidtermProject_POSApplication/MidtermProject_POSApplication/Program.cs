using System;

namespace MidtermProject_POSApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var payment = new CreditCardPayment();

            var ccNumber = payment.GetCardNumber();
            payment.ObscureCCNumber(ccNumber);

            

            Console.WriteLine($"{payment.LastFourDigits}");
        }
    }
}
