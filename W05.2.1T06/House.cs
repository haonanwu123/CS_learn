public class House
{
    public House(double squareMeters, int numberOfRooms)
        : this(squareMeters, numberOfRooms, false, false) { }
    public House(double squareMeters, int numberOfRooms,
        bool isFurnished, bool hasGarden)
    {
        SquareMeters = squareMeters;
        NumberOfRooms = numberOfRooms;
        IsFurnished = isFurnished;
        HasGarden = hasGarden;
    }

    public double SquareMeters { get; protected set; }
    public int NumberOfRooms { get; protected set; }
    public bool IsFurnished { get; private set; }
    public bool HasGarden { get; private set; }

    public double Price
    {
        get
        {
            double basePrice = SquareMeters * 1000;
            double roomPrice = NumberOfRooms * 50000;
            double furnishedPrice = IsFurnished ? 10000 : 0;
            double gardenPrice = HasGarden ? 25000 : 0;
            return basePrice + roomPrice + furnishedPrice + gardenPrice;
        }
    }

    public string Info
    {
        get
        {
            return $"Square meters: {SquareMeters}\n"
            + $"Rooms: {NumberOfRooms}\n"
            + $"Furnished: {(IsFurnished ? "yes" : "no")}\n"
            + $"Garden: {(HasGarden ? "yes" : "no")}";
        }
    }

    public virtual void HomeImprovement()
    {
        SquareMeters += 10;
        IsFurnished = true;
        HasGarden = true;
    }
}