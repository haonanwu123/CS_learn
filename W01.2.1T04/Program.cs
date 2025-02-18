namespace W01._2._1T04;

class Program
{
    static void Main(string[] args)
    {
        const string correctPin = "1234";
        int maxAttempts = 3;

        for (int attemptsLeft = maxAttempts; attemptsLeft > 0; attemptsLeft--)
        {
            Console.WriteLine("Enter your PIn");
            Console.WriteLine($"{attemptsLeft} attempts left");

            string input = Console.ReadLine()!;

            if (input == correctPin)
            {
                Console.WriteLine("Correct!");
                return;
            }
        }

        Console.WriteLine("Your pass is confiscated.");
    }
}
