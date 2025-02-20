namespace W01._2._1T06;

class Program
{
    static void PrintOverview(List<string> tasks)
    {
        Console.WriteLine($"Amount of tasks: {tasks.Count}");

        foreach (string task in tasks)
        {
            Console.WriteLine(task);
        }
    }

    static void Main(string[] args)
    {
        List<string> tasks = [];

        PrintOverview(tasks);

        tasks.Add("Mow lawn");
        tasks.Add("Pay taxes");

        PrintOverview(tasks);

        tasks.Remove("Mow lawn");
        tasks.Add("Shopping");

        PrintOverview(tasks);
    }
}
