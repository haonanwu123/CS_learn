namespace W01._1._2O01;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("How many seconds?");
        int totalSeconds = int.Parse(Console.ReadLine()!);

        int totalHours = totalSeconds / 3600;
        int totalMinutes = (totalSeconds % 3600) / 60;
        int totalSecondsLeft = totalSeconds % 60;

        Console.WriteLine($"Hours: {totalHours}\nMinutes: {totalMinutes}\nSeconds left: {totalSecondsLeft}");
    }
}
