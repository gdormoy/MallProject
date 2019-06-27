namespace Mall
{
    internal class Sandal : IShoe
    {
        private double price = 12.0;
        private string name = "sandales";
        private ShoeType type;

        public Sandal()
        {
        }

        public Sandal(ShoeType type)
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