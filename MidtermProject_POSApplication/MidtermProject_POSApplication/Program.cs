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


            var payment2 = new CashPayment();

            payment2.GetCashPayment();
            Console.WriteLine($"Change owed: {payment2.ProvideChange(payment2.AmountTendered,50)}");
        }
    }
}
