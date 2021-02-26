using System;
namespace MidtermProject_POSApplication
{
    public class Menu
    {
        public Menu()
        {
        }
        public string Item { get; set; }
        public string Description { get; }
        public decimal Price { get; }
        public string Category { get; set; }

        public Menu(string item, string description, decimal price, string category)
        {
            Item = item;
            Description = description;
            Price = price;
            Category = category;

            decimal decimalVal;
            string stringVal = "2,345.26";
            decimalVal = System.Convert.ToDecimal(price);
        }

        public static void TheMenu()
        {
            Console.Write("What Item would you like?");
            Console.WriteLine();

            string line;
            var MenuItem = new List<Menu>();

            System.IO.StreamReader file =
                new System.IO.StreamReader("Inventory.txt");
            while ((line = file.ReadLine()) != null)
            {
                var words = line.Split(',');
                MenuItem.Add(new Menu(words[0], words[0], words[0], words[0]));


            }
        }
}
