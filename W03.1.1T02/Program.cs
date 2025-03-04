namespace W03._1._1T02;

static class Program
{
    static void Main()
    {
        Scale scale = new Scale();
        Console.WriteLine(scale.GetWeight(60));

        scale.UseKg = false;
        Console.WriteLine(scale.GetWeight(60));
    }
}
