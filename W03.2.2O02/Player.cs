public class Player
{
    public const string Name = "Simon Belmont";
    public int CurrentHP { get; set; }
    public int MaxHP { get; set; }
    public int Strength { get; set; }
    public static int Experience;

    public Player(int maxHP, int strength)
    {
        MaxHP = maxHP;
        CurrentHP = maxHP;
        Strength = strength;

        if (Experience == 0)
        {
            Experience = 0;
        }
    }

    public void Attack(Monster monster)
    {
        monster.TakeDamage(this.Strength);
        if (!monster.IsAlive())
        {
            Experience += monster.Experience;
            LevelUp();
        }
    }

    public void TakeDamage(int damage)
    {
        int damageReduced = damage - Strength / 4;
        damageReduced = Math.Max(damageReduced, 0);
        CurrentHP = Math.Max(0, CurrentHP - damageReduced);
    }

    public bool IsAlive()
    {
        return CurrentHP > 0;
    }

    public int GetLevel()
    {
        int level = 1;
        foreach (int exp in World.ExperienceChart)
        {
            if (Experience >= exp)
            {
                level++;
            }
        }
        return level;
    }

    private void LevelUp()
    {
        while (Experience >= World.ExperienceChart[GetLevel() - 1])
        {
            MaxHP += 10;
            Strength += 3;
        }
    }
}