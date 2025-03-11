public static class PersonalInformation
{
    public static void PrintName(string name)
    {
        Console.WriteLine(name);
    }

    public static void PrintName(string fristname, string lastname)
    {
        Console.WriteLine($"{fristname} {lastname}");
    }

    public static void PrintName(char initial, string name)
    {
        Console.WriteLine($"{initial}. {name}");
    }

    public static int IncreaseSalary(int salary)
    {
        return salary + 100;
    }

    public static double IncreaseSalary(int salary, double percentage)
    {
        return salary * (1 + percentage);
    }
}