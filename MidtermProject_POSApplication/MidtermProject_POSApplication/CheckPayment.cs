using System;
using System.Collections.Generic;
using System.Text;

namespace MidtermProject_POSApplication
{
    public class CheckPayment : IPayment
    {
        public string CheckNumber { get; set; }

        public string GetCheckNumber()
        {
            Console.Write("Check number: ");
            string checkNumber = Console.ReadLine();
            CheckNumber = checkNumber;
            return CheckNumber;

        }

    }


}
