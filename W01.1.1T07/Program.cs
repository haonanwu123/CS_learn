namespace W01._1._1T07;

class Program
{
    static void Main(string[] args)
    {
        const string correctWord = "Length";

        Console.WriteLine("You have one chance to guess this six-letter word:");
        Console.WriteLine("Le..th");

        string? guess = Console.ReadLine();

        if (guess == null || guess.Length != 6)
        {
            Console.WriteLine("Incorrect! That is not even a six-letter word!");
        }
        else if (string.Equals(guess, correctWord, StringComparison.Ordinal))
        {
            Console.WriteLine("Correct!");
        }
        else if (string.Equals(guess, correctWord, StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("Kind of correct; the case was just wrong (hint:use ToLower())");
        }
        else
        {
            Console.WriteLine("Incorrect!");
        }
    }
}
