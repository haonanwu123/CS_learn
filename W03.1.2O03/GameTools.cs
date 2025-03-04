static class GameTools
{
    public static readonly Random Rand = new(0);

    public const int MinRoll = 1;

    public static readonly Dictionary<int, Dictionary<int, int>> DiceFrequencies = new()
    {
        { 4, new Dictionary<int, int>() },
        { 6, new Dictionary<int, int>() },
        { 8, new Dictionary<int, int>() },
        { 10, new Dictionary<int, int>() },
        { 12, new Dictionary<int, int>() },
        { 20, new Dictionary<int, int>() }
    };

    public static int RollAndTrackDie(int sides)
    {
        if (!DiceFrequencies.ContainsKey(sides))
        {
            throw new ArgumentException($"Invalid die with {sides} sides.");
        }

        int rollResult = Rand.Next(MinRoll, sides + 1);

        if (!DiceFrequencies[sides].ContainsKey(rollResult))
        {
            DiceFrequencies[sides][rollResult] = 0;
        }
        DiceFrequencies[sides][rollResult]++;

        return rollResult;
    }

    public static int RollAndTrackD20WithAdvantage()
    {
        int roll1 = RollAndTrackD20();
        int roll2 = RollAndTrackD20();
        int higherRoll = Math.Max(roll1, roll2);

        if (!DiceFrequencies[20].ContainsKey(higherRoll))
        {
            DiceFrequencies[20][higherRoll] = 0;
        }
        DiceFrequencies[20][higherRoll]++;

        return higherRoll;
    }

    public static int RollAndTrackD20WithDisadvantage()
    {
        int roll1 = RollAndTrackD20();
        int roll2 = RollAndTrackD20();
        int lowerRoll = Math.Min(roll1, roll2);

        // Track the lower roll
        if (!DiceFrequencies[20].ContainsKey(lowerRoll))
        {
            DiceFrequencies[20][lowerRoll] = 0;
        }
        DiceFrequencies[20][lowerRoll]++;

        return lowerRoll;
    }


    public static int RollAndTrackD4() => RollAndTrackDie(4);
    public static int RollAndTrackD6() => RollAndTrackDie(6);
    public static int RollAndTrackD8() => RollAndTrackDie(8);
    public static int RollAndTrackD10() => RollAndTrackDie(10);
    public static int RollAndTrackD12() => RollAndTrackDie(12);
    public static int RollAndTrackD20() => RollAndTrackDie(20);


}
