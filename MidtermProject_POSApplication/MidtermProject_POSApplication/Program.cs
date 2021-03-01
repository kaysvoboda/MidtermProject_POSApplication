using System;

namespace MidtermProject_POSApplication
{
    class Program
    {
        static void Main(string[] args)
        {




            //Displays Order Total

            var paymentDue = new Math();
            Console.WriteLine($"Subtotal: ${paymentDue.FindSumTotal(15)}"); //update intake for subtotal
            Console.WriteLine($"Tax: ${paymentDue.FindtaxTotal(15)}");
            Console.WriteLine($"Amount Due: ${paymentDue.FindGrandTotal((paymentDue.TaxTotal),15.00M)}");
            Console.WriteLine("-------------------");


            //Gets Payment Type
            Console.WriteLine("Would you like to pay with credit, cash, or check?: ");
            string paymentMethod = Console.ReadLine();
            var payment = PaymentFactory.Tendered.Create(paymentMethod);
            payment.GetPaymentInformation();

            //Start receipt print out
            // Below  - - add a print out of the items ordered for receipt above PrintReceiptInfo line
            Console.WriteLine("-------------------");

            payment.PrintReceiptInfo();
            
            Console.ReadLine();











            






































































































































        }
    }
}
