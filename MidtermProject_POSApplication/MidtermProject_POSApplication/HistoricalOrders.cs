using System;
using System.Collections.Generic;
using System.Text;

namespace MidtermProject_POSApplication
{
    class HistoricalOrders
    {
        public int OrderNumber { get; set; }

        public int UserSelection { get; set; }
        public int UserQuantity { get; set; }
        public string ItemName { get; set; }


        public HistoricalOrders(int orderNumber, string itemName, int userSelection, int userQuantity)
        {
            ItemName = itemName;
            OrderNumber = orderNumber;
            UserSelection = userSelection;
            UserQuantity = userQuantity;
        }
    }
    
}
