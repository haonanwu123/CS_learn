static class Program
{
    static void Main()
    {
        // Asking for input values
        Console.Write("What is the client's name? ");
        string clientName = Console.ReadLine()!;
        Console.Write("What is date of the appointment? ");
        string date = Console.ReadLine()!;
        Console.Write("What is the time of the appointment? ");
        string time = Console.ReadLine()!;
        Console.Write("What is the company's name? ");
        string companyName = Console.ReadLine()!;

        // Template for the email
        string template = "Dear {Name},\n\nThank you for booking an appointment on {Date}.\nWe look forward to seeing you at {Time}.\n\nBest regards,\n{Company}";

        // Creating a dictionary to store the replacements
        var replacements = new Dictionary<string, string>
        {
            { "{Name}", clientName },
            { "{Date}", date },
            { "{Time}", time },
            { "{Company}", companyName }
        };

        // Replace the placeholders with actual values using the dictionary
        foreach (var replacement in replacements)
        {
            template = template.Replace(replacement.Key, replacement.Value);
        }

        // Output the final email
        Console.WriteLine("\nHere is the appointment confirmation:\n");
        Console.WriteLine(template);
    }
}
