public static class Converter
{
    public static T2 ConvertVariables<T1, T2>(T1 value)
    {
        return (T2)Convert.ChangeType(value!, typeof(T2));
    }
}