using System;

namespace Mall
{
    public class ShoesFabric : Shop
    {
        private ShoeCreator ShoeCreator;
        private IShoe shoe;
        private double price;
        
        public ShoesFabric(string name, float areaSize) : base(name, areaSize)
        {
        }

        public override void display()
        {
            string shoeChoice;
            string materialChoice;
            double shoeSize;
            double leatherPrice = 0.20;
            double syntheticPrice = 0.10;
            Console.WriteLine("Bonjour, Quelle type de Chaussure voulez vous ?");
            Console.WriteLine("1 - Sandale | 2 Basket");
            shoeChoice = Console.ReadLine();
            Console.WriteLine("En quel materiaux les voulez vous ?");
            Console.WriteLine("1 - Cuir | 2 Synthetique");
            materialChoice = Console.ReadLine();
            Console.WriteLine("Quelle est votre pointure ?");
            shoeSize = Int32.Parse(Console.ReadLine());
            if (shoeChoice.Equals("1") || shoeChoice.Equals("2"))
            {
                switch (shoeChoice)
                {
                    case "1":
                        switch (materialChoice)
                        {
                            case "1":
                                shoe = (Sandal) ShoeCreator.CreateLeatherSandal();
                                price = shoe.getPrice() + (shoeSize * leatherPrice);
                                break;
                            case "2":
                                shoe = (Sandal) ShoeCreator.CreateSyntheticSandal();
                                price = shoe.getPrice() + (shoeSize * syntheticPrice);
                                break;
                        }
                        break;
                    case "2":
                        switch (materialChoice)
                        {
                            case "1":
                                shoe = (StreetShoe) ShoeCreator.CreateLeatherShoe();
                                price = shoe.getPrice() + (shoeSize * leatherPrice);
                                break;
                            case "2":
                                shoe = (StreetShoe) ShoeCreator.CreateSyntheticShoe();
                                price = shoe.getPrice() + (shoeSize * syntheticPrice);
                                break;
                        }

                        shoe = (StreetShoe) shoe;
                        break;
                }
                
                Console.WriteLine("Merci d'avoir attendu");
                Console.WriteLine("Vos " + shoe.getName() + " sont prête, merci de payer: " + price);
            }

        }
    }
}