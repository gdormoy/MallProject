namespace BurgerKing
{
    public class Ketchup : Decorator
    {
        public Ketchup(BurgersComponent burger) : base(burger)
        {
            this.name = "Ketchup";
            this.price = 1.0;
            this.types = Types.Normal;
        }
    }
}