public static class RewardGenerator
{
    private static readonly Random _random = new Random(0);

    public static T GetRandomElement<T>(List<T> list)
    {
        if (list == null || list.Count == 0)
            throw new ArgumentException("List cannot be null or empty");

        int randomIndex = _random.Next(list.Count);
        return list[randomIndex];
    }
}