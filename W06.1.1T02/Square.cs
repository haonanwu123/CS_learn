public class Square : IDrawable, IResizable
{
    public int Size { get; private set; }
    public Square(int size) => Size = size;

    public void Resize(double scale)
    {
        Size = (int)(Size * scale);
    }

    public void Draw()
    {
        for (int i = 0; i < Size; i++)
        {
            Console.WriteLine(new string('*', Size));
        }
        Console.WriteLine();
    }
}