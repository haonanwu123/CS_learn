class Movie : IAgeSuitability
{
    public string Title { get; }
    private int MinAge { get; }
    private int MaxAge { get; }

    public Movie(string title, int minAge, int maxAge)
    {
        Title = title;
        if (minAge > maxAge)
        {
            (minAge, maxAge) = (maxAge, minAge);
        }
        MinAge = minAge;
        MaxAge = maxAge;
    }

    public string AgeSuitability => $"{MinAge}-{MaxAge}";

    public override string ToString() => $"Movie {Title} (ages {AgeSuitability})";
}
