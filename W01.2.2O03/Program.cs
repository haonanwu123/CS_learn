namespace W01._2._2O03;

class Program
{
    static void Main(string[] args)
    {
        Fighter you = new();
        Fighter enemy = new();

        int turnsTaken = 0;

        while (enemy.Health > 0)
        {
            enemy.Health -= you.Attack();
            turnsTaken++;
        }

        Console.WriteLine($"The enemy's HP was reduced to {enemy.Health}");
        Console.WriteLine($"It took you {turnsTaken} to defeat the enemy");
    }
}
