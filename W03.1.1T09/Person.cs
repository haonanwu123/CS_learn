class Person
{
    public readonly string Name;
    public int Age = 0;

    public Person(string name) => Name = name;

    public void GrowOlder() => Age++;
}
