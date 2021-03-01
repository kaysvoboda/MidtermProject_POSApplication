using System;
using System.Collections.Generic;

namespace MidtermProject_POSApplication
{
    public class Menu
    {
        
        public string ItemNumber { get;}
        public string Item { get; set; }
        public string Description { get; }
        public decimal Price { get; }
        public string Category { get; set; }

        public Menu(string itemNumber, string item, string description, decimal price, string category)
        {
            ItemNumber = itemNumber;
            Item = item;
            Description = description;
            Price = price;
            Category = category;
        }

        public Menu()
        {
        }

        public void TheMenu() 
        {
            Console.Write("What Item would you like?");
            Console.WriteLine();

            string line;
            var menuList= new List<Menu>();

            System.IO.StreamReader file =
                new System.IO.StreamReader("Inventory.txt");
            while ((line = file.ReadLine()) != null)
            {
                var words = line.Split(',');
                menuList.Add(new Menu(words[0], words[1], words[2], 7, words[4]));
            }

            file.Close();

            Console.WriteLine("Beverage");
            foreach (var item in menuList)
            {
                if (item.Category == "Beverage")
                    Console.WriteLine($"{item.ItemNumber} {item.Item} {item.Description} {item.Price} {item.Category}");
            }
            Console.WriteLine();

            Console.WriteLine("Food");
            foreach (var item in menuList)
            {
                if (item.Category == "Food")
                    Console.WriteLine($"{item.ItemNumber} {item.Item} {item.Description} {item.Price} {item.Category}");
            }
            Console.WriteLine();

            Console.WriteLine("Miscellaneous");
            foreach (var item in menuList)
            {
                if (item.Category == "Miscellaneous")
                    Console.WriteLine($"{item.ItemNumber} {item.Item} {item.Description} {item.Price} {item.Category}");

            }
            Console.WriteLine();
        }
    }
}