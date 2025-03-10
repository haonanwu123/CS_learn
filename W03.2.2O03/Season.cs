public class Season
{
    public readonly int Year;
    public readonly List<Race> Races;
    public readonly List<Team> Teams;
    public List<Driver> Drivers { get; }

    public static readonly List<int> PointsForPositions = new List<int> { 25, 18, 15, 12, 10, 8, 6, 4, 2, 1 };

    public Season(int year, List<Race> races, List<Team> teams)
    {
        Year = year;
        Races = races;
        Teams = teams;
        Drivers = teams.SelectMany(team => team.Drivers).ToList();
    }

    public void RunSeason()
    {
        foreach (var race in Races)
        {
            var results = Race.GetRaceResults(Drivers);

            for (int i = 0; i < Math.Min(10, results.Count); i++)
            {
                results[i].DriverPoints += PointsForPositions[i];
            }

            Console.WriteLine($"{results[0].Name} of {results[0].TeamName} has won the {race.Location} Grand Prix!");
        }
    }

    public void PrintSeasonResults()
    {
        var sortedDrivers = Drivers.OrderByDescending(driver => driver.DriverPoints).ToList();
        Console.WriteLine("Season results:");
        for (int i = 0; i < sortedDrivers.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {sortedDrivers[i].Name}: {sortedDrivers[i].DriverPoints}");
        }
    }
}
