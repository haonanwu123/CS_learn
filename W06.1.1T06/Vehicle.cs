public class Vehicle
{
    public string Make { get; }
    public string Model { get; }
    public IEngine Engine { get; }
    public Vehicle(string make, string model, IEngine engine)
    {
        Make = make;
        Model = model;
        Engine = engine;
    }
}