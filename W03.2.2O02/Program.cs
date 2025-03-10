namespace W03._2._2O02;

using System.Reflection;
static class Program
{
    static void Main(string[] args)
    {
        switch (args[1])
        {
            case "Mods": TestFieldModifiers(); return;
            case "TakeDamage": TestTakeDamage(); return;
            case "Fight": TestFighting(); return;
            default: throw new ArgumentException();
        }
    }

    public static void TestFieldModifiers()
    {
        // Class Monster
        Type type = typeof(Monster);
        FieldInfo field = type.GetField("Name");
        Console.WriteLine("Monster's field Name is read-only: " + field.IsInitOnly);

        // Class Player
        type = typeof(Player);
        field = type.GetField("Name");
        Console.WriteLine("Player's field Name is constant: " + field.IsLiteral);

        field = type.GetField("Experience");
        Console.WriteLine("Player's field Experience is static: " + field.IsStatic);
    }

    public static void TestTakeDamage()
    {
        Player player = World.SpawnPlayer();
        player.MaxHP = 1000;
        player.CurrentHP = player.MaxHP;
        player.Strength = 1000; // Make the player absurdly strong for testing the damage reduction

        player.TakeDamage(0);
        PrintPlayerStats(player);
        Console.WriteLine();

        player.TakeDamage(1);
        PrintPlayerStats(player);
        Console.WriteLine();

        player.TakeDamage(100);
        PrintPlayerStats(player);
        Console.WriteLine();

        player.TakeDamage(-1);
        PrintPlayerStats(player);
        Console.WriteLine();

        player.TakeDamage(400);
        PrintPlayerStats(player);
        Console.WriteLine();

        player.TakeDamage(800);
        PrintPlayerStats(player);
    }

    public static void TestFighting()
    {
        Player simon = World.SpawnPlayer();
        PrintPlayerStats(simon);

        Console.WriteLine("Battle 1");
        Monster bat1 = World.SpawnBat();
        PrintMonsterStats(bat1);
        Monster bat2 = World.SpawnBat();
        PrintMonsterStats(bat2);

        simon.Attack(bat1);
        bat2.Attack(simon);
        simon.Attack(bat2);
        PrintPlayerStats(simon);
        PrintMonsterStats(bat1);
        PrintMonsterStats(bat2);

        Console.WriteLine("\nTrap");
        simon.TakeDamage(10);
        PrintPlayerStats(simon);

        Console.WriteLine("\nBattle 2");
        Monster skeleton = World.SpawnSkeleton();
        Monster zombie = World.SpawnZombie();
        simon.Attack(skeleton);
        zombie.Attack(simon);
        simon.Attack(zombie);
        PrintPlayerStats(simon);
        PrintMonsterStats(skeleton);
        PrintMonsterStats(zombie);

        Console.WriteLine("\nBattle 3");
        Monster vampire = World.SpawnVampire();
        while (simon.IsAlive() && vampire.IsAlive())
        {
            simon.Attack(vampire);
            vampire.Attack(simon);
        }
        PrintPlayerStats(simon);
        PrintMonsterStats(vampire);

        Console.WriteLine("\nBattle 3 - Chance 2");
        simon = World.SpawnPlayer();
        vampire = World.SpawnVampire();
        while (simon.IsAlive() && vampire.IsAlive())
        {
            simon.Attack(vampire);
            vampire.Attack(simon);
        }
        PrintPlayerStats(simon);
        PrintMonsterStats(vampire);
    }

    private static void PrintPlayerStats(Player player)
    {
        Console.WriteLine($"{Player.Name} [{player.GetLevel()}]");
        if (!player.IsAlive())
        {
            Console.WriteLine("Dead");
            return;
        }
        Console.WriteLine($"EXP: {Player.Experience}");
        Console.WriteLine($"HP: {player.CurrentHP}/{player.MaxHP}");
        Console.WriteLine($"Strength: {player.Strength}");
    }

    private static void PrintMonsterStats(Monster monster)
    {
        Console.WriteLine($"{monster.Name}'s current HP: {monster.CurrentHP}");
    }
}
