namespace Mall
{
    internal class StreetShoe : IShoe
    {
        private double price = 16.0;
        private string name = "baskets";
        private ShoeType type;

        public StreetShoe()
        {
        }

        public StreetShoe(ShoeType type)
        {
            this.type = type;
        }

        public string getName()
        {
            return this.name;
        }

        public double getPrice()
        {
            return this.price;
        }
    }
}