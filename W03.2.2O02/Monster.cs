public class Monster
{
    public readonly string Name;
    public int CurrentHP { get; private set; }
    public int Strength { get; }
    public int Experience { get; }

    public Monster(string name, int currentHP, int strength, int experience)
    {
        Name = name;
        CurrentHP = currentHP;
        Strength = strength;
        Experience = experience;
    }

    public void Attack(Player player)
    {
        player.TakeDamage(this.Strength);
    }

    public void TakeDamage(int damage)
    {
        CurrentHP = Math.Max(0, CurrentHP - damage);
    }

    public bool IsAlive()
    {
        return CurrentHP > 0;
    }
}