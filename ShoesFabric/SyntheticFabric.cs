using System;

namespace Mall
{
    public abstract class SyntheticFabric : IShoeCreator
    {
        public IShoe CreateSandal()
        {
            throw new NotImplementedException();
        }

        public IShoe CreateShoe()
        {
            throw new NotImplementedException();
        }
    }
}
