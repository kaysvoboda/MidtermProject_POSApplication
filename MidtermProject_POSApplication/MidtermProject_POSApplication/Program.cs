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

            ArrayList historical = new ArrayList();
            var menuList = new List<Menu>();
            var menu = new Menu();
            int orderNumber = 1;
            int userSelection = 1;
            int userQuantity = 1;
            string itemName = null;
            var history = new HistoricalOrders();
            var historicalOrder = new HistoricalOrders(orderNumber, itemName, userSelection, userQuantity);


            for (orderNumber = 1; orderNumber < 200; orderNumber++)
            {

                Console.WriteLine("Welcome to our coffee shop! Check out our menu below and tell us what you'd like today!\n\n-------------------\n");
                menu.TheMenu();
                Console.WriteLine("\n-------------------\n");
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
                    var menuItemName = menuItem.Item;
                    var price = menuItem.Price;
                    double linePrice = price * userQuantity;
                    var order = new Order(menuItemName, userQuantity, price, linePrice);
                    itemName = menuItemName;
                    totalOrder.Add(order);
                    historical.Add(historicalOrder);

                    Console.Write($"You ordered: {userQuantity}x {menuItemName} @ ${price:0.00} = ${linePrice:0.00}\n\nWould you like to make another selection? (y/n): ");
                    userContinue = Console.ReadLine();
                    menuItemName = itemName;

                }
                while (userContinue == "y");

                Console.WriteLine("\n-------------------\n\nOrder Summary:");

                foreach (var item in totalOrder)
                {
                    Console.WriteLine($"{item.MenuItem}, {item.Quantity} x ${item.Price:0.00} = ${item.LinePrice:0.00} ");
                }

                var total = totalOrder.Sum(item => item.LinePrice);
                Console.WriteLine();
                var math = new Math
                {
                    SumTotal = total
                };

                Console.WriteLine($"Subtotal: ${total:0.00}\nTax: ${math.FindtaxTotal(total):0.00} \nAmount Due: ${math.FindGrandTotal((math.TaxTotal), total):0.00}\n");

                var payment = new GetPayment();
                payment.GetPaymentType();
                payment.ReturnPaymentType(payment.PaymentMethod, total);

                Console.WriteLine("-------------------\nORDER SUMMARY\nItems Ordered: ");
                foreach (var item in totalOrder)
                {
                    Console.WriteLine($"{item.MenuItem}, {item.Quantity} x ${item.Price:0.00} = ${item.LinePrice:0.00}");
                }

                Console.WriteLine($"\nSubtotal: ${total:0.00} \nTax: ${math.FindtaxTotal(total):0.00} \nAmount Due: ${math.FindGrandTotal((math.TaxTotal), total):0.00}\n \nPayment Information:");
                payment.CreateReceipt(payment.PaymentMethod);
                Console.WriteLine("\nThank you for stopping by! Hope to see you again soon.\n -------------------");
               
                foreach (var item in historical) //REMOVE BEFORE DEMO - - JUST FOR TESTING
                {
                    Console.WriteLine($"{ orderNumber}, { itemName}, {userQuantity}");
                }
            }
        }
    }
}
