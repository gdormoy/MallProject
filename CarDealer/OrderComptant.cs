using System;
 
 namespace Mall
 {
     public class OrderComptant : Order
     {
         public OrderComptant(double amount) : base(amount)
         {
             
         }
 
         public override bool valid()
         {
             if (amount > 40000.0)
             {
                 return false;
             }

             return true;
         }
 
         public override void payment()
         {
             Console.Write("Cash payment");
         }
     }
 }