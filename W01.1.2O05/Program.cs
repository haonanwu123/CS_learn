namespace W01._1._2O05;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is the month? 1-12");
        int month = int.Parse(Console.ReadLine()!);

        Console.WriteLine("What is the day? 1-31");
        int day = int.Parse(Console.ReadLine()!);

        string season = month switch
        {
            1 or 2 => "Winter",
            3 => day >= 21 ? "Spring" : "Winter",
            4 or 5 => "Spring",
            6 => day >= 21 ? "Summer" : "Spring",
            7 or 8 => "Summer",
            9 => day >= 21 ? "Autumn" : "Summer",
            10 or 11 => "Autumn",
            12 => day >= 21 ? "winter" : "Autumn",
            _ => "Invalid month"
        };

        Console.WriteLine($"On {day}-{month} it is {season}");
    }
}
