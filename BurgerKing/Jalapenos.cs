namespace Mall
{
    public class Jalapenos : Decorator
    {
        public Jalapenos(BurgersComponent burger) : base(burger)
        {
            this.name = "Jalapenos";
            this.price = 1.0;
            this.types = Types.Normal;
        }
    }
}