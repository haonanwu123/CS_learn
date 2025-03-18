namespace W05._1._1T06;

public class Program
{
    public static void Main()
    {
        //Retrieving employees from a database or a file
        List<object> employees = new()
        {
            new Employee(1, "Miles Dyson", "Developer"),
            new Employee(2, "Coleman Reese", "Lawyer"),
            new Manager (3, "Bill Lumbergh", "Manager", 5),
            new Manager (4, "Michael Scott", "Manager", 10),
            new Dog("Owney the mascot dog") //Not an employee
        };
        ListDirectReports(employees);
    }

    public static void ListDirectReports(List<object> employees)
    {
        foreach (var employee in employees)
        {
            Manager? manager = employee as Manager;
            if (manager != null)
            {
                Console.WriteLine($"Manager {manager.Name} has {manager.DirectReportsCount} direct reports.");
            }
        }
    }
}
