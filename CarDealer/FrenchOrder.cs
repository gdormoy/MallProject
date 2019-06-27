using System;

namespace CarDealer
{
    public class FrenchOrder : BaseOrder
    {
        private double preTaxAmount;

        public FrenchOrder(double preTaxAmount){
            this.preTaxAmount = preTaxAmount;
        }

        protected override double CalculateVal(){
            return preTaxAmount * 0.196;
        }

        protected override double CalculatePreTaxAmount(){
            return preTaxAmount;
        }
    }
}
