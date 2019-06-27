using System;
namespace Mall
{
    public class OrderCredit : Order
    {
        public OrderCredit(double amount) : base(amount)
        {
             
        }
 
        public override bool valid()
        {
            if (amount > 1000.0)
            {
                return true;
            }

            return false;
        }
 
        public override void payment()
        {
            Console.Write("Credit payment");
        }
    }
}