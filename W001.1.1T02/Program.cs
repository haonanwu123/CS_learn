namespace W001._1._1T02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user for their age
            Console.WriteLine("What is your age?");
            string? input = Console.ReadLine();

            // Try to convert the input to an integer
            if (!int.TryParse(input, out int age))
            {
                Console.WriteLine("Invalid input. Please enter a valid age.");
                return;
            }

            // String to int conversion example
            Console.WriteLine("You are " + age.ToString() + ". That's old enough to program!");

            // Last year
            Console.WriteLine("Last year you were " + (age - 1).ToString());

            // Next year
            Console.WriteLine("Next year you will be " + (age + 1).ToString());

            // Double your age
            Console.WriteLine("At double your age you will be " + (age * 2).ToString());

            // Next year, double your age
            Console.WriteLine("Next year, double your age will be " + ((age + 1) * 2).ToString());

            // Half your age as a double
            Console.WriteLine("Half your age is " + (age / 2.0).ToString()); // Here age / 2.0 ensures it's a double

            // Half your age, rounded down
            Console.WriteLine("Half your age (rounded down) is " + Convert.ToInt32(age / 2).ToString()); // Converts the division result to int

            // The last digit of your age
            Console.WriteLine("The last digit of your age is " + (age % 10).ToString());
        }
    }
}