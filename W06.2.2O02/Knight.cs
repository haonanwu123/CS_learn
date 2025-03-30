public class Knight : IChessPiece
{
    public int X { get; }
    public int Y { get; }
    public bool IsWhite { get; }

    public Knight(int x, int y, bool isWhite)
    {
        X = x;
        Y = y;
        IsWhite = isWhite;
    }

    public bool CanMove(int x, int y)
    {
        int dx = Math.Abs(X - x);
        int dy = Math.Abs(Y - y);
        return (dx == 2 && dy == 1) || (dx == 1 && dy == 2);
    }

    public override string ToString() =>
        $"{(IsWhite ? "White" : "Black")} Knight at ({X}, {Y})";
}