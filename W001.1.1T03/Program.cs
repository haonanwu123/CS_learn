namespace W001._1._1T03;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is the temperature in Celsius");
        string? input = Console.ReadLine();

        if (!double.TryParse(input, out double celsius))
        {
            Console.WriteLine("Invalid input");
            return;
        }

        double fahrenheit = celsius * 1.8 + 32;

        Console.WriteLine($"{celsius} C = {fahrenheit} F");

        int truncatedFahrenheit = (int)fahrenheit;

        Console.WriteLine($"Truncated that is {truncatedFahrenheit} F");
    }
}
