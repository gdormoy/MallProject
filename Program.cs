namespace Mall
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Display the number of command line arguments:
            System.Console.WriteLine("hello world");
            
            Bigshop bigShop = new Bigshop("bigshop", 200);
            BurgerKing.BurgerKing burgerKing = new BurgerKing.BurgerKing("burger King", 100);
            bigShop.addShop(burgerKing);
            bigShop.display();
        }
    }
}