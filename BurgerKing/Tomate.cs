namespace BurgerKing
{
    public class Tomate : Decorator
    {
        public Tomate(BurgersComponent burger) : base(burger)
        {
            this.name = "Tomate";
            this.price = 1.0;
            this.types = Types.Normal;
        }
    }
}