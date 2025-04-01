public class KeyValuePair<T1, T2>
{
    public T1 Key { get; }
    public T2 Value { get; }

    public KeyValuePair(T1 key, T2 value)
    {
        Key = key;
        Value = value;
    }
}