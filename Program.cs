namespace Mall
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Display the number of command line arguments:
            System.Console.WriteLine("hello world");
            
            Bigshop bigShop = new Bigshop("bigshop", 1000);
            BurgerKing burgerKing = new BurgerKing("burger King", 70);
            CarDealer carDealer = new CarDealer("Concessionnaire", 200);
            ShoesFabric shoesFabric = new ShoesFabric("Cordonnier", 30);
            bigShop.addShop(burgerKing);
            bigShop.addShop(carDealer);
            bigShop.addShop(shoesFabric);
            bigShop.display();
        }
    }
}