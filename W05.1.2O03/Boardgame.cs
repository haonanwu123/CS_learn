class Boardgame
{
    public readonly int NumPlayers;
    private int _turnPlayer = 1;

    private Boardgame(int numPlayers)
    {
        if (numPlayers != 3 && numPlayers != 4)
            throw new ArgumentException("Number of players must be 3 or 4");

        NumPlayers = numPlayers;
    }

    public static Boardgame Create3PlayerGame()
    {
        return new Boardgame(3);
    }

    public static Boardgame Create4PlayerGame()
    {
        return new Boardgame(4);
    }

    public int GetTurnPlayer() => _turnPlayer;
    public void SetNextTurnPlayer() => _turnPlayer = (_turnPlayer % NumPlayers) + 1;
}
