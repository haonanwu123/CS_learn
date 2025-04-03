public class Triple<T1, T2, T3> : Pair<T1, T2>
{
    public T3 Trd { get; private set; }

    public Triple(T1 first, T2 second, T3 third) : base(first, second)
    {
        Trd = third;
    }
}