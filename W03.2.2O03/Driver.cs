public class Driver
{
    public readonly string Name;
    public int DriverPoints { get; set; }
    public string TeamName { get; set; }

    public Driver(string name)
    {
        Name = name;
        DriverPoints = 0;
        TeamName = string.Empty;
    }
}