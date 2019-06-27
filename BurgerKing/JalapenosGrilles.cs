namespace BurgerKing
{
    public class JalapenosGrilles : Decorator
    {
        public JalapenosGrilles(BurgersComponent burger) : base(burger)
        {
            this.name = "Jalapenos Grillés";
            this.price = 1.0;
            this.types = Types.Normal;
        }
    }
}