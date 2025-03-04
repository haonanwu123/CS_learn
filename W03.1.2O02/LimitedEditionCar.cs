class LimitedEditionCar
{
    public const string Model = "McLaren F1";
    public static int Counter = 0;
    public readonly string ChassisNumber;

    public LimitedEditionCar()
    {
        ChassisNumber = "CHNO" + (Counter + 1).ToString();
        Counter++;
    }
}