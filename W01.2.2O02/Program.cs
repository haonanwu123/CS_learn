namespace W01._2._2O02;

static class Program
{
    static void Main()
    {
        string color;
        int number;

        do
        {
            Console.WriteLine("Pick a color (red/blue/green/yellow):");
            color = Console.ReadLine()!.ToLower();
        }
        while (color != "red" && color != "blue" && color != "green" && color != "yellow");

        do
        {
            Console.WriteLine("Pick a number (1-8):");
        }
        while (!int.TryParse(Console.ReadLine(), out number) || number < 1 || number > 8);

        int fortuneNumber = (number + color.Length) % 4 + 1;

        string fortune = GetFortune(fortuneNumber);
        Console.WriteLine(fortune);
    }

    static string GetFortune(int fortuneNumber) => fortuneNumber switch
    {
        1 => "You will be loved and happy!",
        2 => "You will be loved and rich!",
        3 => "You will be loved and famous!",
        4 => "You will be loved, happy, rich, and famous!",
        _ => "Unknown. :( But you will still be loved, no matter what."
    };
}

