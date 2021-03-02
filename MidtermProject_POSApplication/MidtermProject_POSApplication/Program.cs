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

            //var menuList = new List<Menu>();
            menu.SearchMenu();



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

                Console.WriteLine($"{itemName}, ${price.ToString("0.00")} x {userQuantity} = ${linePrice.ToString("0.00")}");

                Console.Write("Would you like to make another selection? (y/n): ");
                userContinue = Console.ReadLine();
            }
            while (userContinue == "y");
      
            foreach(var item in totalOrder)
            {
                Console.WriteLine($"{item.MenuItem}, {item.Quantity} x {item.Price.ToString("0.00")} = {item.LinePrice.ToString("0.00")} ");
            }


            //Displays Order Total
            var paymentDue = new Math();
            //double subtotal = paymentDue.FindSumTotal(totalOrder);


            double sumTotal;
            //PriceList priceList = new PriceList();
            //List<double> practice = priceList.addToList();
            for (int i = 0; i < totalOrder.Count; i++) // need list name
            {
                double sum = 0;
                sumTotal = sum + i;
                Console.WriteLine(sumTotal);
            } 


            //Console.WriteLine($"Subtotal: ${sumTotal}"); 
            //Console.WriteLine($"Tax: ${(paymentDue.FindtaxTotal(sumTotal)).ToString("0.00")}");
            //Console.WriteLine($"Amount Due: ${(paymentDue.FindGrandTotal((paymentDue.TaxTotal),sumTotal)).ToString("0.00")}");
            //Console.WriteLine("-------------------");


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
                Console.WriteLine($" {order.MenuItem} x {order.Quantity}");
            }

            payment.PrintReceiptInfo();
            
            Console.ReadLine();

            // Return to original menu for a new order









            






































































































































        }
    }
}
