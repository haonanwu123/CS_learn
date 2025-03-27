public class StatisticsDisplay : IObserver, IDisplay
{
    private readonly IObservable _observable;
    private double _minTemperature = double.MaxValue;
    private double _maxTemperature = double.MinValue;
    private double _totalTemperature;
    private int _numReadings;

    public StatisticsDisplay(IObservable observable)
    {
        _observable = observable;
    }

    public void Update()
    {
        if (_observable is WeatherData weatherData)
        {
            double temp = weatherData.Temperature;
            _totalTemperature += temp;
            _numReadings++;

            if (temp < _minTemperature)
            {
                _minTemperature = temp;
            }

            if (temp > _maxTemperature)
            {
                _maxTemperature = temp;
            }
        }
    }

    public void Display()
    {
        double avg = _numReadings > 0 ? _totalTemperature / _numReadings : 0;
        Console.WriteLine($"Avg/Min/Max temperature = {avg:F2}/{_minTemperature}/{_maxTemperature}");
    }
}