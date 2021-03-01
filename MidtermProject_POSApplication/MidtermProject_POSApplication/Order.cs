using System;
using System.Collections.Generic;
using System.Text;

namespace MidtermProject_POSApplication
{
    public class Order
    {
        public int UserSelection { get; set; }
        public int Quantity { get; set; }

        public Order (int UserSelection, int Quantity)
        {
            this.UserSelection = UserSelection;
            this.Quantity = Quantity;
        }        
    }
}
