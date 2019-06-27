namespace Mall
{
    public class SaucePiquante : Decorator
    {
        public SaucePiquante(BurgersComponent burger) : base(burger)
        {
            this.name = "Sauce Piquante";
            this.price = 1.0;
            this.types = Types.Normal;
        }
    }
}