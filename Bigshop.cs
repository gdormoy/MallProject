using System;
using System.Collections.Generic;

namespace Mall
{
    public class Bigshop : IShop
    {
        public string Name { get; }
        public float AreaSize { get; }

        public float AreaAvailable { get; set; }
        public List<IShop> Shops { get; }

        public Bigshop(string name, float areaSize)
        {
            this.Name = name;
            this.AreaSize = areaSize;
            this.Shops = new List<IShop>();
            this.AreaAvailable = areaSize;
        }

        public void addShop(IShop shop)
        {
            if (this.AreaAvailable >= shop.AreaSize)
            {
                Shops.Add(shop);
                this.AreaAvailable -= shop.AreaSize;
            }
        }
        
        public void display()
        {
            string selection = "";
            do
            {
                Console.WriteLine("Quelle shop voulez vous voir ?");
                for (int i = 0; i < Shops.Count; i++)
                {
                    Console.WriteLine(i + " - " + Shops[i].Name);
                }

                selection = Console.ReadLine();
                if (selection != "")
                {
                    if (Int32.Parse(selection) <= Shops.Count)
                    {
                        Shops[Int32.Parse(selection)].display();
                    }
                }
            } while (selection != "");
            Console.WriteLine("Au revoir!");
            Environment.Exit(0);
        }
    }
}