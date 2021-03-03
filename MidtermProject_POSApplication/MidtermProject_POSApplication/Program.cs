using System;
using System.Collections;
using System.Collections.Generic;

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
            //Need to incorporate menu and prices
            List<Order> totalOrder = new List<Order>();

            string userContinue = "y";
            int userSelection = 0;
            int userQuantity = 0;
            

            do
            {
                bool itemVerification = false;
                do
                {
                    Console.Write("Please select item number: ");
                    bool validInt = int.TryParse(Console.ReadLine(), out userSelection);

                    if (!validInt || userSelection < 1 || userSelection > 12)
                    {
                        itemVerification = false;
                        Console.WriteLine("invalid entry- please choose a number between 1 and 12");
                    }
                    else
                    {
                        itemVerification = true;
                    }
                   

                }
                while (itemVerification == false);

                bool quantityVerification = false;
                
                    Console.Write("Please enter quantity: ");
                    bool validQuantity = int.TryParse(Console.ReadLine(), out userQuantity);

                    if (!validQuantity || userQuantity < 1 || userQuantity > 100)
                    {
                        itemVerification = false;
                        Console.WriteLine("invalid entry- please choose a number between 1 and 100");
                    }
                    else
                    {
                        quantityVerification = true;
                    }


                    var order = new Order(userSelection, userQuantity);
                totalOrder.Add(order);

                Console.Write("Would you like to make another selection? (y/n): ");
                userContinue = Console.ReadLine();
            }
            while (userContinue == "y");

            
            //Displays Order Total
            var paymentDue = new Math();
                //decimal subtotal = paymentDue.FindSumTotal(15.00M)
                Console.WriteLine($"Subtotal: ${(paymentDue.FindSumTotal(15.00M)).ToString("0.00")}"); //update intake for subtotal
                Console.WriteLine($"Tax: ${(paymentDue.FindtaxTotal(15.00M)).ToString("0.00")}");
                Console.WriteLine($"Amount Due: ${(paymentDue.FindGrandTotal((paymentDue.TaxTotal), 15.00M)).ToString("0.00")}");
                Console.WriteLine("-------------------");


                //Gets Payment Type
                Console.WriteLine("Would you like to pay with credit, cash, or check?: ");
                string paymentMethod = Console.ReadLine();
                var payment = PaymentFactory.Tendered.Create(paymentMethod);
                payment.GetPaymentInformation();

                //Start receipt print out
                // Below  - - add a print out of the items ordered for receipt above PrintReceiptInfo line
                Console.WriteLine("-------------------");

                foreach (var order in totalOrder)
                {
                    Console.WriteLine($"Item # {order.UserSelection} x {order.Quantity}");
                }

                payment.PrintReceiptInfo();

                Console.ReadLine();

                // Return to original menu for a new order


            
            
          





































































































































        }
    }
}
