using System;

namespace MidtermProject_POSApplication
{
    class Program
    {
        static void Main(string[] args)
        {


            var paymentDue = new Math();
            Console.WriteLine($"Subtotal: ${paymentDue.FindSumTotal(15)}"); //update intake
            Console.WriteLine($"Tax: ${paymentDue.FindtaxTotal(15)}");
            Console.WriteLine($"Amount Due: ${paymentDue.FindGrandTotal((paymentDue.TaxTotal),15.00M)}");
            Console.WriteLine("-------------------");

            Console.WriteLine("Would you like to pay with credit, cash, or check?: ");
            string paymentMethod = Console.ReadLine();
            //var payment = PaymentFactory.Tendered.Create(paymentMethod);

            
            var receipt = PaymentFactory.Tendered.Print(paymentMethod);
            receipt.PrintReceiptInfo();
            Console.ReadLine();











            






































































































































        }
    }
}
