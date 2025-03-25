public static class CleaningService
{
    public static void Clean(List<ICleanable> cleanables)
    {
        foreach (var cleanable in cleanables)
        {
            cleanable.Clean();
        }
    }
}