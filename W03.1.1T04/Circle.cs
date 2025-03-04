class Circle
{
    public double Radius;

    public Circle(double radius)
    {
        Radius = radius;
    }

    public double GetArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
}