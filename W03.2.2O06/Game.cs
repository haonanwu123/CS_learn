class Game
{
    public readonly Player Player1;
    public readonly Player Player2;
    public int CurrentRound { get; private set; }
    public const int FirstRound = 1;
    public const int LastRound = 3;
    public static readonly Random Rand; // Static field
    public readonly Dictionary<int, string> RoundWinners;

    // Static constructor to initialize static fields
    static Game()
    {
        Rand = new Random(); // Initialize static Random object here
    }

    // Constructor to initialize Game
    public Game(Player player1, Player player2)
    {
        if (player1 == null || player2 == null)
            throw new ArgumentException("Players cannot be null.");

        Player1 = player1;
        Player2 = player2;
        RoundWinners = new Dictionary<int, string>(); // Initialize the RoundWinners dictionary
        CurrentRound = FirstRound; // Start at the first round
    }

    // Static method for printing game instructions
    public static void PrintInstructions()
    {
        Console.WriteLine("Play 3 rounds. Win at least 2 rounds to win!");
    }

    // Method to play the next round of the game
    public void PlayNextRound()
    {
        if (CurrentRound > LastRound)
            throw new InvalidOperationException("Game is over. No more rounds can be played.");

        string roundAttribute = GetRoundAttribute(); // Determine the round's attribute
        int total = GetTotal(roundAttribute); // Calculate the total of both players' attributes for the round

        double randomValue = Rand.NextDouble() * total; // Generate a random number between 0 and the total value
        string winner = GetRoundWinner(randomValue, roundAttribute); // Determine the winner based on random value

        RoundWinners[CurrentRound] = winner; // Store the winner of the current round
        CurrentRound++; // Move to the next round
    }

    // Method to get the current round's attribute (Skill, Intelligence, or Knowledge)
    private string GetRoundAttribute()
    {
        switch (CurrentRound)
        {
            case 1: return "Skill";        // Round 1: Skill
            case 2: return "Intelligence"; // Round 2: Intelligence
            case 3: return "Knowledge";    // Round 3: Knowledge
            default: throw new InvalidOperationException("Invalid round.");
        }
    }

    // Method to get the total value of the current round's attributes for both players
    private int GetTotal(string attribute)
    {
        int player1Value = 0;
        int player2Value = 0;

        // Access the correct attribute directly based on the current round
        switch (attribute)
        {
            case "Skill":
                player1Value = Player1.Skill;
                player2Value = Player2.Skill;
                break;
            case "Intelligence":
                player1Value = Player1.Intelligence;
                player2Value = Player2.Intelligence;
                break;
            case "Knowledge":
                player1Value = Player1.Knowledge;
                player2Value = Player2.Knowledge;
                break;
            default:
                throw new InvalidOperationException("Invalid attribute.");
        }

        return player1Value + player2Value; // Return the sum of both players' attributes
    }

    // Method to determine the winner of the round based on a random value
    private string GetRoundWinner(double randomValue, string attribute)
    {
        int player1Value = 0;

        // Access the correct attribute directly based on the current round
        switch (attribute)
        {
            case "Skill":
                player1Value = Player1.Skill;
                break;
            case "Intelligence":
                player1Value = Player1.Intelligence;
                break;
            case "Knowledge":
                player1Value = Player1.Knowledge;
                break;
            default:
                throw new InvalidOperationException("Invalid attribute.");
        }

        if (randomValue <= player1Value)
            return Player1.Name; // Player1 wins the round
        else
            return Player2.Name; // Player2 wins the round
    }

    // Method to get the leading player or "Tie"
    public string GetLeadingPlayerNameOrTie()
    {
        int player1Wins = RoundWinners.Values.Count(winner => winner == Player1.Name);
        int player2Wins = RoundWinners.Values.Count(winner => winner == Player2.Name);

        if (player1Wins > player2Wins)
            return Player1.Name;
        else if (player2Wins > player1Wins)
            return Player2.Name;
        else
            return "Tie";
    }

    // Method to get the winner's name or indicate if the game isn't finished
    public string GetWinnerName()
    {
        int player1Wins = RoundWinners.Values.Count(winner => winner == Player1.Name);
        int player2Wins = RoundWinners.Values.Count(winner => winner == Player2.Name);

        if (player1Wins >= 2)
            return Player1.Name; // Player1 wins
        else if (player2Wins >= 2)
            return Player2.Name; // Player2 wins
        else
            return "The game isn't finished yet"; // Game isn't finished
    }

    // Method to reset the game
    public void Reset()
    {
        CurrentRound = FirstRound; // Reset to the first round
        RoundWinners.Clear(); // Clear round winners
    }
}
