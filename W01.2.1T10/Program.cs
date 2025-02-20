namespace W01._2._1T10;

class Program
{
    static void Main(string[] args)
    {
        Random random = new(1);

        for (int i = 0; i < 10; i++)
        {
            int roll = random.Next(1, 7);
            Console.WriteLine(roll);
        }
    }
}
