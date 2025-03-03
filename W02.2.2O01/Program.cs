namespace W02._2._2O01;

static class Program
{
    static void Main()
    {
        Ventilator ventilator = new();
        for (int i = -1; i <= 4; i++)
        {
            ventilator.PressButton(i);
            Console.WriteLine(ventilator.Blow());
        }
    }
}
