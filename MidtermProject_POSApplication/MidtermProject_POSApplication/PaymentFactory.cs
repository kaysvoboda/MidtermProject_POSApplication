using System;
using System.Collections.Generic;
using System.Text;

namespace MidtermProject_POSApplication
{
    public class PaymentFactory
    {
        private PaymentFactory() 
        {
        }
        private static PaymentFactory _tendered;
        public static PaymentFactory Tendered
        {
            get
            {
                if (_tendered == null)
                {
                    _tendered = new PaymentFactory();
                }
                return _tendered;
            }
        }

        public IPayment Create(string paymentMethod)
        {
            switch (paymentMethod.ToLower())
            {
                case "credit":
                    return new CreditCardPayment();

                case "cash":
                    return new CashPayment();
                case "check":
                    return new CheckPayment();
                default:
                    throw new Exception(nameof(paymentMethod));
            }
        }

        public IPayment Print(string paymentMethod)
        {
            switch (paymentMethod.ToLower())
            {
                case "credit":
                    return new CreditCardPayment();
                case "cash":
                    return new CashPayment();
                case "check":
                    return new CheckPayment();
                default:
                    throw new Exception(nameof(paymentMethod));
            }
        }
        public virtual void GetPaymentInformation() 
        {
        }

    }



}
