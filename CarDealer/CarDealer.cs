using System;
using System.Collections.Generic;
using System.Linq;
using Mall;

namespace Mall
{
    public class CarDealer : Shop
    {
        private Dictionary<string, double> frenchVehicles;
        private Dictionary<string, double> GermanVehicles;
        private BaseOrder baseOrder;
        private Order order;
        public CarDealer(string name, float areaSize) : base(name, areaSize)
        {
            this.frenchVehicles = new Dictionary<string, double>{{"Peugeot 208", 15500.0}, {"Peugeot 3008", 25900.0},
                {"Peugeot 308", 17950.0}, {"Renault Clio 4", 10990.0}, {"RENAULT CLIO 5", 14100.0},
                {"Renault Megane 4", 18200.0}, {"RENAULT CAPTUR", 15500.0}, {"ALPINE A110", 54700.0}
            };
            
            this.GermanVehicles = new Dictionary<string, double>{{"AUDI A3", 27420.0}, {"AUDI R8", 143800.0},
                {"VOLKSWAGEN GOLF 7", 17790.0}, {"VOLKSWAGEN POLO 6", 14430.0}, {"VOLKSWAGEN T-ROC", 21990.0},
                {"MERCEDES CLASSE C 4", 31000.0}, {"MERCEDES CLASSE S 7", 89000.0}, {"MERCEDES CLASSE A 4", 27650.0}
            };
        }

        public void setOrder(Dictionary<string,double> vehicles, string type)
        {
            int i = 1;
            string choice;
            Console.WriteLine("Quelle vehicule voulez vous acheter ?");
            foreach (var vehicle in vehicles)
            {
                Console.WriteLine(i + " - " + vehicle.Key + ":" + vehicle.Value);
                i++;
            }

            choice = Console.ReadLine();

            switch (type)
            {
                case "1":
                    this.baseOrder = new FrenchOrder(vehicles.ElementAt(Int32.Parse(choice)).Value);
                    break;
                case "2":
                    double calculateService = vehicles.ElementAt(Int32.Parse(choice)).Value * 0.30;
                    this.baseOrder = new GermanOrder(calculateService,vehicles.ElementAt(Int32.Parse(choice)).Value);
                    break;
            }
            
            do
            {
                Console.WriteLine("Votre commande est une "+ vehicles.ElementAt(Int32.Parse(choice)).Key + " pour: " + this.baseOrder.getPrice() + " euro, souhaitez vous payer ?");
                Console.WriteLine("1 - Comptant | 2 - A credit");
                string payment = Console.ReadLine();
                switch (payment)
                {
                    case "1":
                        order = new OrderComptant(this.baseOrder.getPrice());
                        break;
                    case "2":
                        order = new OrderCredit(baseOrder.getPrice());
                        break;
                    default:
                        Console.WriteLine("Commande Annulée!");
                        break;
                }

                if (!order.valid())
                {
                    Console.WriteLine("Vous ne pouvez pas utilisez ce moyen de paiment!");
                }
            } while (!order.valid());
        }

        public override void display()
        {
            string choice;
            Console.WriteLine("Quelle type de voiture vouslez vous acheter ?");
            Console.WriteLine("1 - Française | 2 - Allemande");
            choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    setOrder(this.frenchVehicles, choice);
                    break;
                case "2":
                    setOrder(this.GermanVehicles, choice);
                    break;
                default:
                    break;
            }
            Console.WriteLine("Au revoir!");
        }
    }
}