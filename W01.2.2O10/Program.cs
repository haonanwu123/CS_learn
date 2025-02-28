namespace W01._2._2O10;

class Program
{
    static void Main(string[] args)
    {
        Random rand = new(0);  // Seed the random number generator with 0 for reproducibility

        Console.WriteLine("Time to play Guess The Number!");

        // Main game loop
        while (true)
        {
            // Ask for minimum number
            Console.WriteLine("Give the minimum number:");
            int min = Convert.ToInt32(Console.ReadLine());

            // Ask for maximum number
            Console.WriteLine("Give the maximum number:");
            int max = Convert.ToInt32(Console.ReadLine());

            // Check if minimum is greater than maximum and swap if needed
            if (min > max)
            {
                Console.WriteLine("The minimum is higher than the maximum. Switching values.");
                (max, min) = (min, max);
            }
            // Check if the minimum is equal to the maximum, then increment the maximum
            else if (min == max)
            {
                Console.WriteLine("The minimum and maximum are equal. Incrementing the maximum by 1.");
                max++;
            }

            // Generate the random number to guess
            int numberToGuess = rand.Next(min, max + 1);  // Generate a number between min and max (inclusive)

            // Start the guessing game
            int guess = -1;
            while (guess != numberToGuess)
            {
                Console.WriteLine($"Guess the number [{min}-{max}]");
                guess = Convert.ToInt32(Console.ReadLine());

                if (guess < numberToGuess)
                {
                    Console.WriteLine("Higher!");
                }
                else if (guess > numberToGuess)
                {
                    Console.WriteLine("Lower!");
                }
                else
                {
                    Console.WriteLine($"{guess} is correct!");
                }
            }

            // Ask the user if they want to play another round
            Console.WriteLine("Do you wish to play another round? Y to continue");
            string playAgain = Console.ReadLine()!;

            if (playAgain.ToLower() is not "y")
            {
                Console.WriteLine("Thank you for playing!");
                break;  // Exit the game if the user doesn't want to play again
            }
        }
    }
}

