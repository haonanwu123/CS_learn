public class Player : IPlayer
{
    public string Name { get; }
    public int Skill { get; }
    public int Intelligence { get; }
    public int Knowledge { get; }
    public const int MinAttributeValue = 1;

    public Player(string name, int skill, int intelligence, int knowledge)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Name cannot be empty or whitespace.");

        if (skill < MinAttributeValue || intelligence < MinAttributeValue || knowledge < MinAttributeValue)
            throw new ArgumentException($"Skill, Intelligence, and Knowledge must all be at least {MinAttributeValue}.");

        Name = name;
        Skill = skill;
        Intelligence = intelligence;
        Knowledge = knowledge;
    }
}