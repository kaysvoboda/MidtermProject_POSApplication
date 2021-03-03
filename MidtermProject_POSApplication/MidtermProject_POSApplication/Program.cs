using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace MidtermProject_POSApplication
{
    class Program
    {
        static void Main(string[] args)
        {


            //Display Menu
            Console.WriteLine("Welcome to our coffee shop! Check out our menu below and tell us what you'd like today!");
            Console.WriteLine();
            Console.WriteLine("-------------------");
            var menu = new Menu();

            menu.TheMenu();
            Console.WriteLine("-------------------");

            //Take in menu item and quantity and display line total (item price * quantity) 


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


            List<Order> totalOrder = new List<Order>();
            string userContinue;

            do
            {
                Console.Write("Please select item number: ");
                int userSelection = int.Parse(Console.ReadLine());
                
                Console.Write("Please enter quantity: ");
                int userQuantity = int.Parse(Console.ReadLine());               

                string line;
                var menuList = new List<Menu>();

                System.IO.StreamReader file =
                    new System.IO.StreamReader("Inventory.txt");
                while ((line = file.ReadLine()) != null)
                {
                    var words = line.Split(',');
                    menuList.Add(new Menu(int.Parse(words[0]), words[1], words[2], double.Parse(words[3]), words[4]));
                }

                file.Close();

                var menuItem = menuList.Find(x => x.ItemNumber == userSelection);
                var itemName = menuItem.Item;
                var price = menuItem.Price;            
                double linePrice = price * userQuantity;
                var order = new Order(itemName, userQuantity, price, linePrice);
                totalOrder.Add(order);

                Console.WriteLine($"You ordered: {userQuantity} {itemName} @ ${price:0.00} = ${linePrice:0.00}");
                Console.WriteLine();


                Console.Write("Would you like to make another selection? (y/n): ");
                userContinue = Console.ReadLine();

            }
            while (userContinue == "y");

            Console.WriteLine("-------------------");
            Console.WriteLine();
            Console.WriteLine("Order Summary:");
            
            foreach (var item in totalOrder)
            {
                Console.WriteLine($"{item.MenuItem}, {item.Quantity} x ${item.Price:0.00} = ${item.LinePrice:0.00} ");                
            }


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


            var total = totalOrder.Sum(item => item.LinePrice);
            Console.WriteLine();
            var math = new Math
            {
                SumTotal = total
            };


            Console.WriteLine($"Subtotal: ${total:0.00}");
            Console.WriteLine($"Tax: ${math.FindtaxTotal(total):0.00}");
            Console.WriteLine($"Amount Due: ${math.FindGrandTotal((math.TaxTotal), total):0.00}");
            Console.WriteLine();


            //Get Payment:
            var payment = new GetPayment();
            payment.GetPaymentType();
            payment.ReturnPaymentType(payment.PaymentMethod, total);

            //Print Receipt with order summary:
            Console.WriteLine("-------------------");
            Console.WriteLine();
            Console.WriteLine("Today's Order: ");
            Console.WriteLine();

            Console.WriteLine("Items Ordered:");
            foreach (var item in totalOrder)
            {
                Console.WriteLine($"{item.MenuItem}, {item.Quantity} x ${item.Price:0.00} = ${item.LinePrice:0.00} ");
            }
            Console.WriteLine();
            Console.WriteLine("Payment Information:");
            payment.CreateReceipt(payment.PaymentMethod);
            Console.WriteLine("Thank you for stopping by! Hope to see you again soon.");

            // Return to original menu for a new order

            // Write some code..

            // changes


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
