namespace Mall
{
    public class Mayonnaise : Decorator
    {
        public Mayonnaise(BurgersComponent burger)
            : base(burger)
        {
            this.name = "Mayonnaise";
            this.price = 1.0;
            this.types = Types.Normal;
        }
    }
}