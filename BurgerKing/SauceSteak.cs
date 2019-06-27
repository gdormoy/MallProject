namespace Mall
{
    public class SauceSteak : Decorator
    {
        public SauceSteak(BurgersComponent burger) : base(burger)
        {
            this.name = "Sauce Steak";
            this.price = 1.0;
            this.types = Types.Normal;
        }
    }
}