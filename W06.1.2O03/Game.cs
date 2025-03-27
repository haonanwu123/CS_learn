public class Game
{
    public readonly IPlayer Player1;
    public readonly IPlayer Player2;

    public Game(IPlayer player1, IPlayer player2)
    {
        Player1 = player1 ?? throw new ArgumentNullException(nameof(player1));
        Player2 = player2 ?? throw new ArgumentNullException(nameof(player2));
    }
}