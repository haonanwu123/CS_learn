namespace W02._1._2O01;

public static class Program
{
    public static void Main()
    {
        PrintIsLeapYear(1000);
        PrintIsLeapYear(1500);
        PrintIsLeapYear(2000);
        PrintIsLeapYear(2004);
        PrintIsLeapYear(2005);
    }

    public static bool IsDivisibleBy(int dividend, int divisor)
    {
        return dividend % divisor == 0;
    }

    public static bool IsLeapYear(int year)
    {
        return IsDivisibleBy(year, 4) && !IsDivisibleBy(year, 100) || IsDivisibleBy(year, 400);
    }

    public static void PrintIsLeapYear(int year)
    {
        if (IsLeapYear(year))
        {
            Console.WriteLine($"{year} is a leap year");
        }
        else
        {
            Console.WriteLine($"{year} is not a leap year");
        }
    }
}
