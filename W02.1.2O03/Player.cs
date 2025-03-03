class Player
{
    public string Name { get; private set; }
    public int HealthPoints { get; private set; }
    public int Power { get; private set; }

    public Player(string name, int power)
    {
        Name = name;
        Power = power;
        HealthPoints = 100;
    }

    public bool IsAlive()
    {
        return HealthPoints > 0;
    }

    public void TakeDamage(int damage)
    {
        HealthPoints -= damage;
        if (HealthPoints < 0)
        {
            HealthPoints = 0;
        }
    }
}