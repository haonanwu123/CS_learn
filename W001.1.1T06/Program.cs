static class Program
{
    static void Main()
    {
        Console.WriteLine("Give some text");
        string? text = Console.ReadLine();

        Console.WriteLine("What do you want to do with this text?");
        Console.WriteLine("U: make all uppercase");
        Console.WriteLine("L: make all lowercase");
        Console.WriteLine("Any other key: do not change");

        string? choice = Console.ReadLine()?.ToUpper();

        // if (choice == "U")
        // {
        //     string? newText = text?.ToUpper();
        //     Console.WriteLine(newText);
        // }
        // else if (choice == "L")
        // {
        //     string? newText = text?.ToLower();
        //     Console.WriteLine(newText);
        // }
        // else
        // {
        //     string? newText = text;
        //     Console.WriteLine(newText);
        // }

        string? newText = (choice == "U") ? text?.ToUpper() :
                        (choice == "L") ? text?.ToLower() :
                        text;

        Console.WriteLine(newText);
    }
}
