using System;
namespace MidtermProject_POSApplication
{
    class Beverage : Menu
    {
        public Beverage(string item, string description, decimal price) : base(item, description, price, "beverage")
        {

        }
    }
}
