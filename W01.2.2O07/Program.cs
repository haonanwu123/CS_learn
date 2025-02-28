namespace W01._2._2O07;

class Program
{
    static void Main(string[] args)
    {
        int number;
        Console.WriteLine("Give a number from 2-9: ");
        number = Convert.ToInt32(Console.ReadLine());

        if (number < 2)
        {
            number = 2;
        }

        if (number > 9)
        {
            number = 9;
        }

        Console.Write("  |");
        for (int i = 1; i <= number; i++)
        {
            Console.Write($"{i,4}");
        }
        Console.WriteLine();
        Console.WriteLine(new string('-', (number * 4) + 4));

        for (int row = 1; row <= number; row++)
        {
            Console.Write($"{row} |");
            for (int col = 1; col <= number; col++)
            {
                Console.Write($"{row * col,4}");
            }
            Console.WriteLine();
        }
    }
}
