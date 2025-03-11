static class WebShop
{
    public static readonly string Domain = "https://www.mysticmercantile.com";
    public static readonly string FullURL;
    public static readonly string Path = "/enchanted-items";

    static WebShop() => FullURL = Domain + Path;

    public static readonly List<Item> ItemsForSale = [
        new Item("Dwarvish Plate", 10),
        new Item("Elven Crystal Mug", 12),
        new Item("Dragonbone Fork", 15),
        new Item("Orcish Bone Knife", 7),
        new Item("Wizard's Wand Spoon", 6),

        new MagicItem("Polarizing Pumps", 5, "These shoes repel each other, so that they are always at least one meter apart"),
        new MagicItem("Enchanted Mirror", 20, "Reflects the true self of the beholder"),
        new MagicItem("Teleporting Toilet Paper", 5, "Always there when you need it... or not"),
        new MagicItem("Phoenix Feather Quill", 8, "Writes with flames, burning your papers to a crisp"),
        new MagicItem("Invisibility Cloak Hanger", 20, "Keeps your cloak hidden, even from you"),
        new MagicItem("Laughing Doormat", 15, "Giggles every time you wipe your feet"),
        new MagicItem("Mystic Lantern", 12, "Illuminates only what the user desires to see, but is fueled by unicorn urine"),
        new MagicItem("Fairy Dust Pouch", 10, "Allows brief flight for a short period"),
    ];

    public static void AddToCart(string itemName)
    {
        var item = ItemsForSale.FirstOrDefault(i => i.Name == itemName);

        if (item != null)
        {
            ShoppingCart.AddItem(item, 1);
        }
        else
        {
            Console.WriteLine($"Item {itemName} not found");
        }
    }

    public static void AddToCart(string itemName, int quantity)
    {
        var item = ItemsForSale.FirstOrDefault(i => i.Name == itemName);
        if (item != null)
        {
            if (quantity < 1) quantity = 1;
            ShoppingCart.AddItem(item, quantity);
        }
        else
        {
            Console.WriteLine($"Item {itemName} not found");
        }
    }

    public static void CheckoutItem(string itemName)
    {
        var item = ItemsForSale.FirstOrDefault(i => i.Name == itemName);
        if (item != null)
        {
            CheckoutItem(itemName, 1);
        }
        else
        {
            Console.WriteLine($"Item {itemName} not found");
        }
    }

    public static void CheckoutItem(string itemName, int quantity)
    {
        var item = ItemsForSale.FirstOrDefault(i => i.Name == itemName);
        if (item != null)
        {
            ShoppingCart.Checkout(new GroupedItem(item, quantity));
        }
        else
        {
            Console.WriteLine($"Item {itemName} not found");
        }
    }
}
