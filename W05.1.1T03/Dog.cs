public class Dog : Animal
{
    public Dog(string name) : base(name)
    {
        Sound = "Woof!";
    }

    public void Fetch()
    {
        Console.WriteLine($"{Name} is fetching a ball.");
    }
}