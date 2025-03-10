public class Patient
{
    private static int _counter = 1;

    public readonly string Id;
    public string Name { get; }
    public int Age { get; }

    public Patient(string name, int age)
    {
        Id = $"PAT{_counter:D3}";
        Name = name;
        Age = age;
        _counter++;
    }
}
