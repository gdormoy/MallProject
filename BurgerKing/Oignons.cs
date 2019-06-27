namespace BurgerKing
{
    public class Oignons : Decorator
    {
        public Oignons(BurgersComponent burger) : base(burger)
        {
            this.name = "Oignons";
            this.price = 1.0;
            this.types = Types.Normal;
        }
    }
}