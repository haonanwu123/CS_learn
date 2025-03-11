class GroupedItem
{
    public readonly Item MyItem;
    public int Quantity;
    public const int MinQuantity = 1;

    public GroupedItem(Item item, int quantity)
    {
        MyItem = item;
        Quantity = quantity;
    }

    public void SetQuantity(int newQuantity)
    {
        Quantity = newQuantity < MinQuantity ? MinQuantity : newQuantity;
    }

    public int GetTotalPrice()
    {
        return MyItem.Price * Quantity;
    }
}