namespace W04._1._1T01;

static class Program
{
    static void Main(string[] args)
    {
        PersonalInformation.PrintName("John Doe");
        PersonalInformation.PrintName("Jane", "Doe");
        PersonalInformation.PrintName("J", "Doe");

        Console.WriteLine(PersonalInformation.IncreaseSalary(2248, 0.95));
        Console.WriteLine(PersonalInformation.IncreaseSalary(2345, 0.10));
    }
}
