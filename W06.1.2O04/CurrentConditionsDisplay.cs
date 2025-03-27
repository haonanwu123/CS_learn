public class CurrentConditionsDisplay : IObserver, IDisplay
{
    private readonly IObservable _observable;
    private double _temperature;
    private double _humidity;

    public CurrentConditionsDisplay(IObservable observable)
    {
        _observable = observable;
    }

    public void Update()
    {
        if (_observable is WeatherData weatherData)
        {
            _temperature = weatherData.Temperature;
            _humidity = weatherData.Humidity;
        }
    }

    public void Display()
    {
        Console.WriteLine($"Current conditions: {_temperature}C degrees and {_humidity}% humidity");
    }
}