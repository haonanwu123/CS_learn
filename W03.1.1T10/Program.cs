namespace W03._1._1T10;

static class Program
{
    static void Main()
    {
        DatabaseManager dbm = new();

        Console.WriteLine($"Current connection: {dbm.Connection}");
    }
}
