class Car
{
    public const int NumberOfWheels = 4;
    public string Color;

    public Car(string color)
    {
        Color = color;
    }

    public void ChangePaintColor(string color) => Color = color;

    public string GetInfo()
    {
        return $"My color is currently {Color}, although that may change. "
            + $"But I will always have {NumberOfWheels} wheels.";
    }
}
