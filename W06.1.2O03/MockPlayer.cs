public class MockPlayer : IPlayer
{
    public string Name { get; }
    public int Skill { get; }
    public int Intelligence { get; }
    public int Knowledge { get; }

    public MockPlayer(string name, int skill, int intelligence, int knowledge)
    {
        Name = name;
        Skill = skill;
        Intelligence = intelligence;
        Knowledge = knowledge;
    }
}