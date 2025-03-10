class Deck
{
    public readonly List<Card> Cards = new();

    private static readonly string[] Suits = { "Diamonds", "Clubs", "Hearts", "Spades" };
    private static readonly string[] Ranks = { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };
    private static readonly Random rng = new();

    public Deck(bool areJokersIncluded)
    {
        foreach (string suit in Suits)
        {
            foreach (string rank in Ranks)
            {
                Cards.Add(new Card(rank, suit));
            }
        }

        if (areJokersIncluded)
        {
            Cards.Add(new Card("Joker", "Red"));
            Cards.Add(new Card("Joker", "Black"));
        }
        Shuffle();
    }

    public void Shuffle()
    {
        int n = Cards.Count();
        for (int i = n - 1; i > 0; i--)
        {
            int j = rng.Next(i + 1);
            (Cards[i], Cards[j]) = (Cards[j], Cards[i]); // SwapShuffle();
        }
    }

    public Card? Draw()
    {
        if (Cards.Count == 0)
        {
            return null;
        }

        Card topCard = Cards[^1]; // Get last card
        Cards.RemoveAt(Cards.Count - 1);
        return topCard;
    }
}