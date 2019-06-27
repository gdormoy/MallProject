namespace Mall
{
    public interface IShop
    {
        string Name { get; }
        
        float AreaSize { get; }

        void display();
    }
}