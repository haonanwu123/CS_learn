namespace W001._1._1T05;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is the temperature of the water ? (Celsius)");
        double temperature = Convert.ToDouble(Console.ReadLine());

        // if (temperature <= 0)
        // {
        //     Console.WriteLine($"At {temperature} degrees Celsius, the water will be solid");
        // }
        // else if (temperature > 0 && temperature < 100)
        // {
        //     Console.WriteLine($"At {temperature} degrees Celsius, the water will be liquid");
        // }
        // else if (temperature >= 100)
        // {
        //     Console.WriteLine($"At {temperature} degrees Celsius, the water will be gas");
        // }
        // else
        // {
        //     Console.WriteLine("Invalid temperature");
        // }

        string result = (temperature <= 0) ? $"At {temperature} degrees Celsius, the water will be solid" :
                        (temperature > 0 && temperature < 100) ? $"At {temperature} degrees Celsius, the water will be liquid" :
                        (temperature >= 100) ? $"At {temperature} degrees Celsius, the water will be gas" :
                        "Invalid temperature";

        Console.WriteLine(result);
    }
}
