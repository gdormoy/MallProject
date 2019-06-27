namespace BurgerKing
{
    public class ChampignonsGrilles : Decorator
    {
        public ChampignonsGrilles(BurgersComponent burger) : base(burger)
        {
            this.name = "Champignons Grillés";
            this.price = 1.0;
            this.types = Types.Null;
        }
    }
}