public class Clothes : Product
{
    public string Size;
    public string Material;

    public Clothes(string name, double price, int stock, string size, string material) : base(name, price, stock)
    {
        Size = size;
        Material = material;
    }

    private string WashingInstructions()
    {
        return Material switch
        {
            "Cotton" => "Gentle",
            "Wool" => "Hand",
            "Linen" => "Washing machine",
            _ => "Unknown"
        };
    }

    public override void Sell(int units)
    {
        base.Sell(units);
        Console.WriteLine(WashingInstructions());
    }

    public override string ToString()
    {
        return base.ToString() + $"; size: {Size}; material: {Material}";
    }
}