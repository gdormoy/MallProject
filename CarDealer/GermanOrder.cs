using System;

namespace CarDealer
{
    public class GermanOrder : BaseOrder
    {
        private double preTaxServiceAmount;
        private double preTaxMaterialAmount;

        public GermanOrder(double preTaxServiceAmount, double preTaxMaterialAmount){
            this.preTaxServiceAmount = preTaxServiceAmount;
            this.preTaxMaterialAmount = preTaxMaterialAmount;
        }

        protected override double CalculateVal(){
            return preTaxServiceAmount +
            preTaxMaterialAmount * 0.15;
        }

        protected override double CalculatePreTaxAmount(){
            return preTaxServiceAmount + preTaxMaterialAmount;
        }
    }
}
