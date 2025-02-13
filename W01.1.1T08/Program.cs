namespace W01._1._1T08;

class Program
{
    static void Main(string[] args)
    {
        int xPosition = 0;
        int yPosition = 0;
        Console.WriteLine("What direction (up/down/left/right) would you like to go?");

        string? direction = Console.ReadLine()?.ToLower();

        switch (direction)
        {
            case "up":
                yPosition += 1;
                break;
            case "down":
                yPosition -= 1;
                break;
            case "left":
                xPosition -= 1;
                break;
            case "right":
                xPosition += 1;
                break;
            default:
                Console.WriteLine("Invalid direction");
                break;
        }

        Console.WriteLine($"Current positon\nX:{xPosition}, Y:{yPosition}");
    }
}
