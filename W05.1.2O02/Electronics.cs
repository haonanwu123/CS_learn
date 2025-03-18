public class Electronics : Product
{
    public string Brand;
    public string Model;
    private const int _minimumStock = 10;

    public Electronics(string name, double price, int stock, string brand, string model) : base(name, price, stock)
    {
        Brand = brand;
        Model = model;
    }

    public override void Sell(int units)
    {
        base.Sell(units);
        Restock();
    }

    private void Restock()
    {
        if (Stock < _minimumStock)
        {
            Stock = _minimumStock;
        }
    }

    public override string ToString()
    {
        return $"Name: {Name} ({Brand} {Model}); price: {Price}; stock: {Stock}";
    }
}