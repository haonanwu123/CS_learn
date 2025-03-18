class Cuboid : Rectangle
{
    public int Height;

    public Cuboid(int length, int width, int height) : base(length, width)
    {
        Height = height;
    }

    public int Volume() => Length * Width * Height;

    public override int Area() => 2 * (Length * Width + Length * Height + Width * Height);

    public override string Info() => base.Info() + $"; Height: {Height}";

}