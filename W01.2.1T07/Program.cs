namespace W01._2._1T07;

static class Program
{
    static void Main()
    {
        Dictionary<string, int> fruitBasket = new() {
            { "Apple", 3 },
            { "Orange", 2 },
            { "Pear", 4 },
        };

        Console.Write("Add what fruit? ");
        string fruitToAdd = Console.ReadLine()!;

        if (fruitBasket.TryGetValue(fruitToAdd, out int count))
        {
            fruitBasket[fruitToAdd] = count + 1;
        }
        else
        {
            fruitBasket[fruitToAdd] = 1;
        }

        Console.WriteLine("\nFruit count:");
        foreach (string fruit in fruitBasket.Keys)
        {
            Console.WriteLine($" - {fruit}: {fruitBasket[fruit]}");
        }
    }
}
