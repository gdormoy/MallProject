namespace BurgerKing
{
    public class Cornichons : Decorator
    {
        public Cornichons(BurgersComponent burger) : base(burger)
        {
            this.name = "Cornichons";
            this.price = 1.0;
            this.types = Types.Normal;
        }
    }
}