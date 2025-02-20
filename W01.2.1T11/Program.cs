namespace W01._2._1T11
{
    static class Program
    {
        static void Main()
        {
            int attack = 50;
            double critChance = 0.33;
            int bossHP = 500;

            Random random = new();

            while (bossHP > 0)
            {
                Console.WriteLine($"Boss HP: {bossHP}");
                int damage = attack;

                if (random.NextDouble() < critChance)
                {
                    damage *= 2;
                }

                bossHP -= damage;

                if (bossHP < 0) bossHP = 0;

                Console.WriteLine($"Damage: {damage}");
                Console.WriteLine();
            }

            Console.WriteLine("Boss defeated");
        }
    }
}
