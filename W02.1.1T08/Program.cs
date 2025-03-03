namespace W02._1._1T08;

static class Program
{
    static void Main()
    {
        PlayingCard card = new("Spades", "Ace");
        Console.WriteLine(card.GetDescription());
    }
}
