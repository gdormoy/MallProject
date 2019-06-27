using System;
using Mall;
using System.Collections.Generic;

namespace BurgerKing
{
    public class BurgerKing : Shop
    {
        private string choice = "";
        private BurgersComponent baseBurger;
        private BurgersComponent finalBurger;
        
        public BurgerKing(string name, float areaSize) : base(name, areaSize)
        {
        }

        public void setBurger()
        {
            Console.WriteLine("Choisit ton burger:");
            Console.WriteLine("1 - Little Cheesburger, prix: 7€");
            Console.WriteLine("2 - Cheesburger, prix: 10€");
            Console.WriteLine("3 - Bacon Cheesburger, prix: 11€");
            choice = Console.ReadLine();
            
            switch (choice)
            {
                case "1":
                    baseBurger = new LittleChesseburger();
                    break;
                case "2":
                    baseBurger = new Cheeseburger();
                    break;
                case "3":
                    baseBurger = new BaconCheeseburger();
                    break;
                default:
                    Console.WriteLine("Au revoir!");
                    choice = "";
                    break;
            }

            finalBurger = addComponent(baseBurger);
        }

        public BurgersComponent addComponent(BurgersComponent burger)
        {
            BurgersComponent component = burger;
            do
            {
                Console.WriteLine("Ajouter des ingredient ?");
                Console.WriteLine("1 - Champignons Grillés, prix: 1€");
                Console.WriteLine("2 - Cornichon, prix: 1€");
                Console.WriteLine("3 - Jalapenos, prix: 1€");
                Console.WriteLine("4 - Jalapenos Grillés, prix: 1€");
                Console.WriteLine("5 - Oignons, prix: 1€");
                Console.WriteLine("6 - Oignons Grillés, prix: 1€");
                Console.WriteLine("7 - Poivron vert, prix: 1€");
                Console.WriteLine("8 - Salade, prix: 1€");
                Console.WriteLine("9 - Tomate, prix: 1€");
                Console.WriteLine("10 - Ketchup, prix: 1€");
                Console.WriteLine("11 - Mayonnaise, prix: 1€");
                Console.WriteLine("12 - Moutard, prix: 1€");
                Console.WriteLine("13 - Sauce BBQ, prix: 1€");
                Console.WriteLine("14 - Sauce Piquante, prix: 1€");
                Console.WriteLine("15 - Sauce Steak, prix: 1€");
                choice = Console.ReadLine();

                switch (choice)
                {
                     case "1":
                         component = new ChampignonsGrilles(component);
                         break;
                     case "2":
                         component = new Cornichons(component);
                         break;
                     case "3":
                         component = new Jalapenos(component);
                         break;
                     case "4":
                         component = new JalapenosGrilles(component);
                         break;
                     case "5":
                         component = new Oignons(component);
                         break;
                     case "6":
                         component = new OignonsGrilles(component);
                         break;
                     case "7":
                         component = new PoivronVert(component);
                         break;
                     case "8":
                         component = new Salade(component);
                         break;
                     case "9":
                         component = new Tomate(component);
                         break;
                     case "10":
                         component = new Ketchup(component);
                         break;
                     case "11":
                         component = new Mayonnaise(component);
                         break;
                     case "12":
                         component = new Moutarde(component);
                         break;
                     case "13":
                         component = new SauceBarbecue(component);
                         break;
                     case "14":
                         component = new SaucePiquante(component);
                         break;
                     case "15":
                         component = new SauceSteak(component);
                         break;
                     default:
                         choice = "";
                         break;
                }
                
            } while (choice != "");

            return component;
        }

        public override void display()
        {
            int burgernameSize;
            setBurger();
            Console.WriteLine("Recapitulatif de votre commande:");
            Console.WriteLine("Burger : " + baseBurger.GetName());
            Console.WriteLine("Vous avez rajouté les ingredients suivant:");
            burgernameSize = baseBurger.GetName().Length + 2;
            Console.WriteLine(finalBurger.GetName().Substring(burgernameSize));
            Console.WriteLine("pour un total de:" + finalBurger.GetPrice());
        }
    }
}