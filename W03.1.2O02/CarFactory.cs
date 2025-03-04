class CarFactory
{
    private readonly int limit;

    public CarFactory(int limit)
    {
        this.limit = limit;
    }

    public LimitedEditionCar ProduceLimitedEditionCar()
    {
        if (LimitedEditionCar.Counter < limit)
        {
            return new LimitedEditionCar();
        }
        else
        {
            return null!;
        }
    }
}