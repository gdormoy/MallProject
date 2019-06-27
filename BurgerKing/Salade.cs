namespace BurgerKing
{
    public class Salade : Decorator
    {
        public Salade(BurgersComponent burger) : base(burger)
        {
            this.name = "Salade";
            this.price = 1.0;
            this.types = Types.Normal;
        }
    }
}