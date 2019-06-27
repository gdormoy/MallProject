using System;

namespace CarDealer
{
    public abstract class BaseOrder : IOrder
    {
        public double CalculateAmount(){
            return CalculateVal() + CalculatePreTaxAmount();
        }

        protected abstract double CalculateVal();

        protected abstract double CalculatePreTaxAmount();
    }
}
