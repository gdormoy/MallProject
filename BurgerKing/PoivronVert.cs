namespace BurgerKing
{
    public class PoivronVert : Decorator
    {
        public PoivronVert(BurgersComponent burger) : base(burger)
        {
            this.name = "Poivron Vert";
            this.price = 1.0;
            this.types = Types.Normal;
        }
    }
}