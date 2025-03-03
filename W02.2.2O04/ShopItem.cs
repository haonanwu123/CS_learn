class ShopItem
{
    public string ID { get; private set; }
    public string Name { get; private set; }
    public double Price { get; private set; }

    public ShopItem(string id, string name, double price)
    {
        ID = id;
        Name = name;
        Price = price;
    }
}