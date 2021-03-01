using System;

namespace MidtermProject_POSApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            //Display Menu
            var menu = new Menu();
            menu.TheMenu();

            //Take in menu item and quantity and display line total (item price * quantity) 
            
            
            
            //ask if user would like to add anything else until "no"



            //Display order



            //Displays Order Total
            var paymentDue = new Math();
            //decimal subtotal = paymentDue.FindSumTotal(15.00M)
            Console.WriteLine($"Subtotal: ${(paymentDue.FindSumTotal(15.00M)).ToString("0.00")}"); //update intake for subtotal
            Console.WriteLine($"Tax: ${(paymentDue.FindtaxTotal(15.00M)).ToString("0.00")}");
            Console.WriteLine($"Amount Due: ${(paymentDue.FindGrandTotal((paymentDue.TaxTotal),15.00M)).ToString("0.00")}");
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

            // Return to original menu for a new order









            






































































































































        }
    }
}
