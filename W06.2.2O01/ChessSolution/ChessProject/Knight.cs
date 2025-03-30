public class Knight : ChessPiece
{
    public Knight(int x, int y, bool isWhite) : base(x, y, isWhite) { }

    public override bool CanMove(int x, int y)
    {
        int dx = Math.Abs(X - x);
        int dy = Math.Abs(Y - y);
        return (dx == 2 && dy == 1) || (dx == 1 && dy == 2);
    }

    public override string ToString() => $"{(IsWhite ? "White" : "Black")} Knight at ({X}, {Y})";
}