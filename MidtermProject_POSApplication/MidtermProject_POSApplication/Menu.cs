using System;
using System.Collections.Generic;

namespace MidtermProject_POSApplication
{
    public class Menu
    {
        
        public int ItemNumber { get; set; }
        public string Item { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string Category { get; set; }

        public Menu(int itemNumber, string item, string description, double price, string category)
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

        public void SearchMenu()
        {
            //string line;
            //var menuList = new List<Menu>();


            //System.IO.StreamReader file =
            //    new System.IO.StreamReader("Inventory.txt");
            //while ((line = file.ReadLine()) != null)
            //{
            //    var words = line.Split(',');
            //    menuList.Add(new Menu(int.Parse(words[0]), words[1], words[2], double.Parse(words[3]), words[4]));
            //}

            //file.Close();
        }


        public void TheMenu() 
        {
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

            Console.WriteLine("Beverage: ");
            foreach (var item in menuList)
            {
                if (item.Category.ToLower().Contains("beverage"))
                    Console.WriteLine($"{item.ItemNumber}: {item.Item} {item.Description} - ${item.Price} - {item.Category}");
            }
            Console.WriteLine();

            Console.WriteLine("Food: ");
            foreach (var item in menuList)
            {
                if (item.Category.ToLower().Contains("food"))
                    Console.WriteLine($"{item.ItemNumber}: {item.Item} {item.Description} - ${item.Price} - {item.Category}");
            }
            Console.WriteLine();

            Console.WriteLine("Miscellaneous: ");
            foreach (var item in menuList)
            {
                if (item.Category.ToLower().Contains("miscellaneous"))
                    Console.WriteLine($"{item.ItemNumber}: {item.Item} {item.Description} - ${item.Price} - {item.Category}");
            }
            Console.WriteLine();           
        }
    }
}