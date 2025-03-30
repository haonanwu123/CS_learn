namespace ChessPieces.Tests
{
    [TestClass]
    public class ChessPiecesTest
    {
        [DataTestMethod]
        [DataRow(1, 3, true)]  // L-shape move (x-1, y+2)
        [DataRow(4, 2, true)]   // L-shape move (x+2, y+1)
        [DataRow(4, 3, false)]  // Not valid knight move
        public void CanMove_WhiteKnight(int x, int y, bool expected)
        {
            // Arrange
            var knight = new Knight(2, 1, true);

            // Act
            bool result = knight.CanMove(x, y);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [DataTestMethod]
        [DataRow(6, 6, true)]  // L-shape move (x-1, y-2)
        [DataRow(5, 7, true)]   // L-shape move (x-2, y-1)
        [DataRow(8, 8, false)]  // Not valid knight move
        public void CanMove_BlackKnight(int x, int y, bool expected)
        {
            // Arrange
            var knight = new Knight(7, 8, false);

            // Act
            bool result = knight.CanMove(x, y);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}