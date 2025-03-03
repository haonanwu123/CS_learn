namespace W02._1._1T09;

static class Program
{
    static void Main()
    {
        Console.WriteLine("Give three names.");
        Console.Write("The first name: ");
        string name1 = Console.ReadLine()!;
        Console.Write("The second name: ");
        string name2 = Console.ReadLine()!;
        Console.Write("The third name: ");
        string name3 = Console.ReadLine()!;

        Console.WriteLine($"{Longest(name1, name2, name3)} has the longest name");
    }

    static string Longest(string s1, string s2, string s3)
    {
        if (s1.Length > s2.Length && s1.Length > s3.Length) { return s1; }
        if (s2.Length > s1.Length && s2.Length > s3.Length) { return s2; }
        if (s3.Length > s1.Length && s3.Length > s2.Length) { return s3; }
        return s3;
    }
}

