using System;

namespace Mall
{
    public abstract class LeatherFabric : IShoeCreator
    {
        public IShoe CreateSandal(){
            Sandal sandale = new Sandal();
            return sandale;
        }
        public IShoe CreateShoe(){
            StreetShoe shoe = new StreetShoe();
            return shoe;
        }
        
    }
}
