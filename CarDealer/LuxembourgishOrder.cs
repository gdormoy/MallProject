using System;

namespace CarDealer
{
    public class LuxembourgishOrder : BaseOrder
    {
        private double preTaxServiceAmount;
        private double preTaxMaterialAmount;

        public LuxembourgishOrder(double preTaxServiceAmount, double preTaxMaterialAmount){
            this.preTaxServiceAmount = preTaxServiceAmount;
            this.preTaxMaterialAmount = preTaxMaterialAmount;
        }

        protected override double CalculateVal(){
            return preTaxServiceAmount * 0.12 +
            preTaxMaterialAmount * 0.15;
        }

        protected override double CalculatePreTaxAmount(){
            return preTaxServiceAmount + preTaxMaterialAmount;
        }
    }
}
