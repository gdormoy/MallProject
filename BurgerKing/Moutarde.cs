namespace Mall
{
    public class Moutarde : Decorator
    {
        public Moutarde(BurgersComponent burger) : base(burger)
        {
            this.name = "Moutarde";
            this.price = 1.0;
            this.types = Types.Normal;
        }
    }
}