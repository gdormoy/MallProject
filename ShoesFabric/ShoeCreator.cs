﻿namespace Mall
{
    public class ShoeCreator : IShoeCreator
    {
        public IShoe CreateLeatherShoe()
        {
            return new StreetShoe(ShoeType.Leather);
        }

        public IShoe CreateLeatherSandal()
        {
            return new Sandal(ShoeType.Leather);
        }

        public IShoe CreateSyntheticShoe()
        {
            return new StreetShoe(ShoeType.Synthetic);
        }

        public IShoe CreateSyntheticSandal()
        {
            return new Sandal(ShoeType.Synthetic);
        }

        public IShoe CreateSandal()
        {
            return new Sandal();
        }

        public IShoe CreateShoe()
        {
            return new StreetShoe();
        }
    }
}
