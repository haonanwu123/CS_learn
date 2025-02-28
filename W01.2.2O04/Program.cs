namespace W01._2._2O04;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the start number: ");
        int start = int.Parse(Console.ReadLine()!);

        Console.WriteLine("Enter the end number: ");
        int end = int.Parse(Console.ReadLine()!);

        for (int i = start; i <= end; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (i % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (i % 5 == 0)
                Console.WriteLine("Buzz");
            else
                Console.WriteLine(i);
        }
    }
}
