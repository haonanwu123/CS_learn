public class Race
{
    public readonly string Location;
    public List<Driver> Drivers { get; set; }

    public Race(string location)
    {
        Location = location;
        Drivers = new List<Driver>();
    }

    public static List<Driver> GetRaceResults(List<Driver> allDrivers)
    {
        Random random = new Random();
        List<Driver> randomizedDrivers = new List<Driver>(allDrivers);
        for (int i = randomizedDrivers.Count - 1; i > 0; i--)
        {
            int j = random.Next(i + 1);
            var temp = randomizedDrivers[i];
            randomizedDrivers[i] = randomizedDrivers[j];
            randomizedDrivers[j] = temp;
        }
        return randomizedDrivers;
    }
}
