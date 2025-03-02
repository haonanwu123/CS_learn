namespace W02._1._1T05;

static class Program
{
    static void Main()
    {
        Square square1 = new(5);
        Console.WriteLine($"Side: {square1.Side}");
        Console.WriteLine($"Area: {square1.GetArea()}");
        Console.WriteLine($"Perimeter: {square1.GetPerimeter()}");

        Square square2 = new(10);
        Console.WriteLine($"Side: {square2.Side}");
        Console.WriteLine($"Area: {square2.GetArea()}");
        Console.WriteLine($"Perimeter: {square2.GetPerimeter()}");
    }
}
