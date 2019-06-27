using System;

namespace Mall
{
    public class Shop : IShop
    {
        public string Name { get; }
        public float AreaSize { get; }

        public Shop(string name, float areaSize)
        {
            this.Name = name;
            this.AreaSize = areaSize;
        }

        public virtual void display()
        {
            Console.WriteLine(this.ToString());
        }
    }
}