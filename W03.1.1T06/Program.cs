namespace W03._1._1T06;

class Program
{
    static void Main(string[] args)
    {
        const int spdOfLightInMperS = 299792458;
        const double daysInYear = 365.242199;
        const string planetName = "LP 890-9b";
        const double distanceFromEarthInLightYear = 100;

        double distanceInMeters = distanceFromEarthInLightYear * spdOfLightInMperS * daysInYear * 24 * 60 * 60;

        Console.WriteLine($"The planet {planetName} is {distanceFromEarthInLightYear} lightyears away from Earth");
        Console.WriteLine($"In meters this is {distanceInMeters:E}");
    }
}
