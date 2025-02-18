namespace W01._1._2O03;
class Program
{
    static void Main()
    {
        int score = 0;

        Console.WriteLine("Answer the following MCQs:");

        // First Question
        Console.WriteLine("Which of the following is NOT a valid type in C#?");
        Console.WriteLine("A: bool");
        Console.WriteLine("B: int");
        Console.WriteLine("C: var");
        Console.WriteLine("D: string");
        Console.Write("> ");
        string answer1 = (Console.ReadLine() ?? string.Empty).Trim().ToUpper();
        if (answer1 == "C") score++;

        // Second Question
        Console.WriteLine("\nWhat happens if you execute the following line C#?");
        Console.WriteLine("int x = 1.23;");
        Console.WriteLine("A: x will be 1.23");
        Console.WriteLine("B: x will be 1");
        Console.WriteLine("C: x will be 1.0");
        Console.WriteLine("D: you will get a compiler error");
        Console.Write("> ");
        string answer2 = (Console.ReadLine() ?? string.Empty).Trim().ToUpper();
        if (answer2 == "D") score++;

        // Third Question
        Console.WriteLine("\nConsider the following line:");
        Console.WriteLine("double d = 1.23;");
        Console.WriteLine("What are TWO ways to convert variable d to an int?");
        Console.WriteLine("A: int i = (int)d;");
        Console.WriteLine("B: int i = int(d)");
        Console.WriteLine("C: int i = 0 + d");
        Console.WriteLine("D: int i = Convert.ToInt32(d)");
        Console.Write("Your first answer:\n> ");
        string answer3a = (Console.ReadLine() ?? string.Empty).Trim().ToUpper();
        Console.Write("Your second answer:\n> ");
        string answer3b = (Console.ReadLine() ?? string.Empty).Trim().ToUpper();

        if ((answer3a == "A" && answer3b == "D") || (answer3a == "D" && answer3b == "A"))
        {
            score++;
        }

        if (score == 3)
        {
            Console.WriteLine($"Your score: {score} out of 3. Well done!");
        }
        else
        {
            Console.WriteLine($"Your score: {score} out of 3.");
        }
    }
}
