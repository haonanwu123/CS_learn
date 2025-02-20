namespace W01._2._1T09;

class Program
{
    static void Main(string[] args)
    {
        Random random = new();

        for (int i = 0; i < 10; i++)
        {
            int roll = random.Next(1, 7);
            Console.WriteLine(roll);
        }
    }
}
