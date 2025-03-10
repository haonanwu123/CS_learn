public class Team
{
    public readonly string Name;
    public readonly List<Driver> Drivers;

    public Team(string name)
    {
        Name = name;
        Drivers = new List<Driver>();
    }

    public void ContractDriver(Driver driver)
    {
        if (Drivers.Count < 2)
        {
            Drivers.Add(driver);
            driver.TeamName = this.Name;
        }
    }
}