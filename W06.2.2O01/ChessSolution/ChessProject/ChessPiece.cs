public abstract class ChessPiece
{
    public int X { get; protected set; }
    public int Y { get; protected set; }
    public bool IsWhite { get; protected set; }

    protected ChessPiece(int x, int y, bool isWhite)
    {
        X = x;
        Y = y;
        IsWhite = isWhite;
    }

    public abstract bool CanMove(int x, int y);
}