public class WeatherData : IObservable
{
    private List<IObserver> _observers = new List<IObserver>();
    public double Temperature { get; private set; }
    public double Humidity { get; private set; }
    public double Pressure { get; private set; }

    public void RegisterObserver(IObserver observer)
    {
        _observers.Add(observer);
    }

    public void RemoveObserver(IObserver observer)
    {
        _observers.Remove(observer);
    }

    public void NotifyObservers()
    {
        foreach (var observer in _observers)
        {
            observer.Update();
        }
    }

    public void SetMeasurements(double temperature, double humidity, double pressure)
    {
        Temperature = temperature;
        Humidity = humidity;
        Pressure = pressure;
        MeasurementsChanged();
    }

    private void MeasurementsChanged()
    {
        NotifyObservers();
    }
}