﻿using System;

namespace CarDealer
{
    public abstract class Order
    {
        protected double amount;

        public Order(double amount)
        {
            this.amount = amount;
        }

        public abstract bool valid();

        public abstract void payment();
    }
}