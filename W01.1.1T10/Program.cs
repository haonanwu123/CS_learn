static class EmailParser
{
    static void Main()
    {
        Console.Write("Please enter your email address: ");
        string emailAddress = Console.ReadLine()!;

        if (string.IsNullOrEmpty(emailAddress)) // Check if it is null or empty
        {
            Console.WriteLine("Null or empty email address");
            return;
        }

        if (!emailAddress.Contains('@')) // Check if it contains an @
        {
            Console.WriteLine("Email address does not contain @");
            return;
        }
        if (!emailAddress.Contains('.')) // Check if it contains a period (punt)
        {
            Console.WriteLine("Email address does not contain .");
            return;
        }

        emailAddress = emailAddress.Trim().ToLower(); // Remove any leading and trailing whitespaces, and make it lowercase
        Console.WriteLine($"Trimmed and lowercase: {emailAddress}");

        int indexOfAtSign = emailAddress.IndexOf('@'); // Index of the @
        Console.WriteLine($"Index of @: {indexOfAtSign}");
        int indexOfPeriod = emailAddress.IndexOf('.'); // Index of the .
        Console.WriteLine($"Index of period: {indexOfPeriod}");

        string[] emailComponents = emailAddress.Split('@'); // Divide the email address in what comes before and after the @
        string userName = emailComponents[0];
        string domainName = emailComponents[1];
        string topLevelDomain = domainName.Substring(domainName.LastIndexOf('.') + 1); // Take the part of the email address after the .

        Console.WriteLine();
        Console.WriteLine($"User name: {userName}");
        Console.WriteLine($"Domain name: {domainName}");
        Console.WriteLine($"Top-level domain: {topLevelDomain}");
    }
}
