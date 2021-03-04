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




            var historicalOrder = new List<HistoricalOrders>();
            var menuList = new List<Menu>();
            var menu = new Menu();
            int i = 0;
            int orderNumber = i + 1;
            int userSelection = 1;
            int userQuantity = 1;
            string menuItemName = null;


            for (orderNumber = 1; orderNumber < 200; orderNumber++)
            {

                Console.WriteLine("Welcome to our coffee shop! Check out our menu below and tell us what you'd like today!");
                Console.WriteLine();
                Console.WriteLine("-------------------");
                menu.TheMenu();
                Console.WriteLine("-------------------");

                //Take in menu item and quantity and display line total (item price * quantity) 

                List<Order> totalOrder = new List<Order>();
                string userContinue = "y";


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

                    do
                    {
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

                    }

                    while (quantityVerification == false);

                    string line;


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
                    menuItemName = itemName;
                    historicalOrder.Add(new HistoricalOrders(orderNumber, menuItemName, userSelection, userQuantity));

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
                Console.WriteLine($"Subtotal: ${total:0.00}");
                Console.WriteLine($"Tax: ${math.FindtaxTotal(total):0.00}");
                Console.WriteLine($"Amount Due: ${math.FindGrandTotal((math.TaxTotal), total):0.00}");
                Console.WriteLine();
                Console.WriteLine("Payment Information:");
                payment.CreateReceipt(payment.PaymentMethod);
                Console.WriteLine();
                Console.WriteLine("Thank you for stopping by! Hope to see you again soon.");
                Console.WriteLine();
                Console.WriteLine("-------------------");

                foreach (var item in historicalOrder)
                {
                    Console.WriteLine($"Order Number: { orderNumber}, Item Name: {menuItemName}, Quantity: { userQuantity}");
                }

            }
        }
    }
}
