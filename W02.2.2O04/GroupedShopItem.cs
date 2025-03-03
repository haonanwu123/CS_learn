class GroupedShopItem
{
    public ShopItem Item { get; private set; }
    public int Quantity { get; private set; }

    public GroupedShopItem(ShopItem item)
    {
        Item = item;
        Quantity = 1;
    }

    public void IncrementQuantity()
    {
        Quantity++;
    }
}