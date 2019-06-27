namespace Mall
{
    public class SauceBarbecue : Decorator
    {
        public SauceBarbecue(BurgersComponent burger) : base(burger)
        {
            this.name = "Sauce Barbecue";
            this.price = 1.0;
            this.types = Types.Normal;
        }
    }
}