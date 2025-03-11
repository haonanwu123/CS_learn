static class ShoppingCart
{
    public static readonly List<GroupedItem> ItemsToOrder = new List<GroupedItem>();

    public static void AddItem(Item item, int quantity)
    {
        var existingItem = ItemsToOrder.FirstOrDefault(g => g.MyItem.Name == item.Name);

        if (existingItem != null)
        {
            existingItem.SetQuantity(existingItem.Quantity + quantity);
        }
        else
        {
            ItemsToOrder.Add(new GroupedItem(item, quantity));
        }
    }

    public static void IncrementItemQuantity(string itemName)
    {
        var item = ItemsToOrder.FirstOrDefault(g => g.MyItem.Name == itemName);
        if (item == null)
        {
            Console.WriteLine($"Item {itemName} not found");
            return;
        }

        item.SetQuantity(item.Quantity + 1);
    }

    public static void DecrementItemQuantity(string itemName)
    {
        var item = ItemsToOrder.FirstOrDefault(g => g.MyItem.Name == itemName);
        if (item == null)
        {
            Console.WriteLine($"Item {itemName} not found");
            return;
        }

        item.SetQuantity(item.Quantity - 1);
    }

    public static void SetItemQuantity(string itemName, int newQuantity)
    {
        var item = ItemsToOrder.FirstOrDefault(g => g.MyItem.Name == itemName);
        if (item == null)
        {
            Console.WriteLine($"Item {itemName} not found");
            return;
        }

        item.SetQuantity(newQuantity);
    }

    public static void RemoveItem(string itemName)
    {
        var item = ItemsToOrder.FirstOrDefault(g => g.MyItem.Name == itemName);
        if (item == null)
        {
            Console.WriteLine($"Item {itemName} not found");
            return;
        }

        ItemsToOrder.RemoveAll(g => g.MyItem.Name == itemName);
    }

    public static void EmptyCart()
    {
        ItemsToOrder.Clear();
    }

    public static void Checkout()
    {
        int totalPrice = ItemsToOrder.Sum(g => g.GetTotalPrice());
        Console.WriteLine($"The total price is {totalPrice}. Thank you!");
        EmptyCart();
    }

    public static void Checkout(GroupedItem groupedItem)
    {
        Console.WriteLine($"The price is {groupedItem.GetTotalPrice()}. Thank you!");
    }
}