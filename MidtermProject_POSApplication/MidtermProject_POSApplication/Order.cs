using System;
using System.Collections.Generic;
using System.Text;

namespace MidtermProject_POSApplication
{
    public class Order
    {
        public string MenuItem { get; set; }
        public double Quantity { get; set; }
        public double Price { get; set; }
        public double LinePrice { get; set; }

        public Order (string MenuItem, double Quantity, double Price, double LinePrice)
        {
            this.MenuItem = MenuItem;
            this.Quantity = Quantity;
            this.Price = Price;
            this.LinePrice = LinePrice;
        }        
    }
}
