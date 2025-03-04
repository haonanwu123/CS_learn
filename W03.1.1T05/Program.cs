namespace W03._1._1T05;

static class Program
{
    static void Main()
    {
        Console.WriteLine("What is your first name?");
        string? firstName = Console.ReadLine();
        Console.WriteLine("What is your last name?");
        string? lastName = Console.ReadLine();

        string? fullName = GetFullName(firstName, lastName);
        Console.WriteLine(fullName);
    }

    public static string? GetFullName(string? fName, string? lName) => $"{fName} {lName}";
}

