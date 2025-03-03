class ShoppingCart
{
    public List<GroupedShopItem> Groceries { get; private set; }

    public ShoppingCart()
    {
        Groceries = new List<GroupedShopItem>();
    }

    public void AddItem(ShopItem item)
    {
        // Check if the item already exists in the cart
        var existingItem = Groceries.FirstOrDefault(g => g.Item.ID == item.ID);
        if (existingItem != null)
        {
            existingItem.IncrementQuantity();
        }
        else
        {
            Groceries.Add(new GroupedShopItem(item));
        }
    }

    public GroupedShopItem? FindItem(ShopItem item)
    {
        return Groceries.FirstOrDefault(g => g.Item.ID == item.ID);
    }

    public string GetContentsOverview()
    {
        string overview = "";
        foreach (var gItem in Groceries)
        {
            overview += $"{gItem.Item.Name} x {gItem.Quantity}\n";
        }
        return overview;
    }

    public double GetTotalPrice()
    {
        double totalPrice = 0;
        foreach (var gItem in Groceries)
        {
            totalPrice += gItem.Item.Price * gItem.Quantity;
        }
        return totalPrice;
    }
}