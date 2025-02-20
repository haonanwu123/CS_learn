class Program
{
    static void Main()
    {
        List<double> grades = [7, 5.5, 3.2, 10, 4.5];

        int passCount = 0;
        int totalCount = grades.Count;

        foreach (double grade in grades)
        {
            if (grade >= 5.5)
            {
                passCount++;
            }
        }

        Console.WriteLine($"{passCount} out of {totalCount} students passed");
    }
}
