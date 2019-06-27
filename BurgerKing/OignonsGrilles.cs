namespace Mall
{
    public class OignonsGrilles : Decorator
    {
        public OignonsGrilles(BurgersComponent burger) : base(burger)
        {
            this.name = "Oignons Grillés";
            this.price = 1.0;
            this.types = Types.Normal;
        }
    }
}