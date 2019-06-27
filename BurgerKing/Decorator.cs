namespace BurgerKing
{
    public abstract class Decorator : BurgersComponent
    {
        BurgersComponent BaseComponent = null;
 
        protected string name = "Decorateur indéfini";
        protected double price = 0.0;
        protected Types types = Types.Null;
 
        protected Decorator(BurgersComponent burger)
        {
            BaseComponent = burger;
        }
        
        public override string GetName()
        {
            return string.Format("{0}, {1}", BaseComponent.GetName(), name);
        }
 
        public override double GetPrice()
        {
            return price + BaseComponent.GetPrice();
        }
        
        public Types GetType()
        {
            return types;
        }
        
        public void setType(Types types)
        {
            this.types = types;
        }
    }
}