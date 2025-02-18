namespace W01._1._2O04;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is the month? 1-12");
        int month = int.Parse(Console.ReadLine()!);

        Console.WriteLine("What is the day? 1-31");
        int day = int.Parse(Console.ReadLine()!);

        string season;

        switch (month)
        {
            case 1:
            case 2:
                season = "Winter";
                break;
            case 3:
                season = day >= 21 ? "Spring" : "Winter";
                break;
            case 4:
            case 5:
                season = "Spring";
                break;
            case 6:
                season = day >= 21 ? "Summer" : "Spring";
                break;
            case 7:
            case 8:
                season = "Summer";
                break;
            case 9:
                season = day >= 21 ? "Autumn" : "Summer";
                break;
            case 10:
            case 11:
                season = "Autumn";
                break;
            case 12:
                season = day >= 21 ? "Winter" : "Autumn";
                break;
            default:
                Console.WriteLine("Invalid month");
                return;

        }

        Console.WriteLine($"On {day}-{month} it is {season}");
    }
}
