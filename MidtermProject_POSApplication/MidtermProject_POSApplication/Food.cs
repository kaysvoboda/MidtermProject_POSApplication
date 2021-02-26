using System;
namespace MidtermProject_POSApplication
{
    class Food : Menu
    {
        public Food(string item, string description, decimal price) : base(item, description, price, "food")
        {

        }
    }
}
