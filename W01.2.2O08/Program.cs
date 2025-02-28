namespace W01._2._2O08;

class Program
{
    static void Main(string[] args)
    {
        double[] grades = [6.5, 9.5, 4, 5, 4.5, 10, 7.1];

        for (int i = 0; i < grades.Length; i++)
        {
            Console.WriteLine($"Grade: {grades[i]}");

            if (grades[i] < 5.5)
            {
                string answer;

                do
                {
                    Console.WriteLine("Retake this course? y/n");
                    answer = Console.ReadLine()!;
                }
                while (answer.ToLower() is not "y" and not "n");

                if (answer.ToLower() is "y")
                {
                    grades[i] += 1;
                }
            }
        }

        Console.WriteLine("Final grades:");
        foreach (var grade in grades)
        {
            Console.WriteLine(grade);
        }
    }
}
