namespace W01._2._2O06;

class Program
{
    static void Main(string[] args)
    {
        int size;

        do
        {
            Console.WriteLine("Enter the board size (at least 2): ");
            size = Convert.ToInt32(Console.ReadLine());
        }
        while (size < 2);

        for (int row = 0; row < size; row++)
        {
            for (int col = 0; col < size; col++)
            {
                if (size % 2 == 0)
                {
                    if ((row + col) % 2 == 0)
                    {
                        Console.Write("W");
                    }
                    else
                    {
                        Console.Write("B");
                    }
                }
                else
                {
                    if ((row + col) % 2 == 0)
                    {
                        Console.Write("B");
                    }
                    else
                    {
                        Console.Write("W");
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
