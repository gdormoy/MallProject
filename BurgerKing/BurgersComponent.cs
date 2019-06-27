namespace Mall
{
    public abstract class BurgersComponent
    {
        protected string name;
        public virtual string GetName()
        {
            return name;
        }
 
        protected double price;
        public virtual double GetPrice()
        {
            return price;
        }
    }
}