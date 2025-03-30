public interface IChessPiece
{
    int X { get; }
    int Y { get; }
    bool IsWhite { get; }
    bool CanMove(int x, int y);
}