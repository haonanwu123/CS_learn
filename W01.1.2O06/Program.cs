namespace W01._1._2O06;

class Program
{

    static bool AskDirection(string direction)
    {
        Console.WriteLine($"{direction}? Y/N");
        string input = Console.ReadLine()!.Trim().ToUpper();
        return input == "Y";
    }
    static void Main(string[] args)
    {
        bool canGoNorth = AskDirection("North");
        bool canGoEast = AskDirection("East");
        bool canGoSouth = AskDirection("South");
        bool canGoWest = AskDirection("West");

        Console.WriteLine("Give a bearing (a number) for the direction in which you are going.");
        int bearing = int.Parse(Console.ReadLine()!);

        bearing = ((bearing % 360) + 360) % 360;

        string direction = bearing switch
        {
            > 315 or <= 45 => "North",
            > 45 and <= 135 => "East",
            > 135 and <= 225 => "South",
            > 225 and <= 315 => "West"
        };

        Console.WriteLine("From here you can go:");
        if (canGoNorth)
        {
            Console.WriteLine("    N");
            Console.WriteLine("    |");
        }
        else Console.WriteLine();

        if (canGoWest && !canGoEast)
        {
            Console.WriteLine("W---|");
        }
        else if (canGoEast && !canGoWest)
        {
            Console.WriteLine("    |---E");
        }
        else if (canGoWest && canGoWest)
        {
            Console.WriteLine("W---|---E");
        }
        else
        {
            Console.WriteLine("    |");
        }

        if (canGoSouth)
        {
            Console.WriteLine("    |");
            Console.WriteLine("    S");
            Console.WriteLine();
        }
        else Console.WriteLine();

        bool canMove = direction switch
        {
            "North" => canGoNorth,
            "East" => canGoEast,
            "South" => canGoSouth,
            "West" => canGoWest,
            _ => false
        };

        Console.WriteLine(canMove ? $"You are going {direction}" : $"You can't go {direction}");
    }
}
