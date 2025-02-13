namespace W01._1._1T09;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter an age");

        if (int.TryParse(Console.ReadLine(), out int age))
        {
            string ageClass = age switch
            {
                >= 0 and <= 12 => "a child",
                >= 13 and <= 19 => "a teenager",
                >= 20 and <= 150 => "an adult",
                _ => "invalid"
            };

            Console.WriteLine($"Age {age}: {ageClass}");
        }
        else
        {
            Console.WriteLine("Invalid input");
        }
    }
}
