namespace RollTheDice.Tests
{
    public class RollTheDiceTest
    {
        [Fact]
        public void Create_Die()
        {
            var die = new Die(6, "Red");

            Assert.InRange(die.Value, 1, 6);
            Assert.Equal(6, die.Sides);
            Assert.Equal("Red", die.Color);
        }

        [Theory]
        [InlineData(4)]
        [InlineData(6)]
        [InlineData(8)]
        [InlineData(20)]
        public void Roll_Die(int sides)
        {
            var die = new Die(sides, "Blue");

            for (int i = 0; i < 10; i++)
            {
                die.Roll();
                Assert.InRange(die.Value, 1, sides);
            }
        }

        [Fact]
        public void Create_DiceBag()
        {
            var diceBag = new DiceBag();

            // 验证 Dice 列表不为 NULL
            Assert.NotNull(diceBag.Dice);

            // 验证 Dice 列表为空
            Assert.Empty(diceBag.Dice);
        }

        [Fact]
        public void Add_DiceToDiceBag()
        {
            var diceBag = new DiceBag();
            var die1 = new Die(6, "Green");
            var die2 = new Die(8, "Yellow");

            diceBag.Add(die1);
            diceBag.Add(die2);

            Assert.Equal(2, diceBag.Dice.Count);

            Assert.All(diceBag.Dice, die => Assert.NotNull(die));

            Assert.InRange(die1.Value, 1, 6);
            Assert.InRange(die2.Value, 1, 8);
        }

        [Fact]
        public void Reroll_AllDiceInDiceBag()
        {
            var diceBag = new DiceBag();
            var die1 = new Die(6, "Green");
            var die2 = new Die(8, "Yellow");

            diceBag.Add(die1);
            diceBag.Add(die2);

            diceBag.Reroll();

            Assert.InRange(die1.Value, 1, 6);
            Assert.InRange(die2.Value, 1, 8);
        }
    }
}
