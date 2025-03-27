class BoardGame : Toy
{
    public string Publisher { get; }

    public BoardGame(string name, string publisher, int minAge, int maxAge) : base(name, minAge, maxAge)
    {
        Publisher = publisher;
    }

    public override string ToString() => $"{Name} by {Publisher} (ages {AgeSuitability})";

    public override string AgeSuitability => base.AgeSuitability;
}
