class Toy : IAgeSuitability
{
    public string Name { get; }
    public int MinAge { get; }
    public int MaxAge { get; }

    public Toy(string name, int minAge, int maxAge)
    {
        Name = name;
        if (minAge > maxAge)
        {
            (minAge, maxAge) = (maxAge, minAge);
        }
        MinAge = minAge;
        MaxAge = maxAge;
    }

    public virtual string AgeSuitability => $"{MinAge}-{MaxAge}";

    public override string ToString() => $"{Name} (ages {AgeSuitability})";
}
