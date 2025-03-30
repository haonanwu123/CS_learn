namespace W06._2._1T05;

class Program
{
    static void Main(string[] args)
    {
        Employee john = new Employee("John", "Doe", "john.doe@example.com");
        Employee jane = new Manager("Jane", "Doe", "jane.doe@example.com", "Sales");
        Employee bob = new SalesPerson("Bob", "Smith", "bob.smith@example.com", 100000);

        john.PrintEmployeeInfo();
        jane.PrintEmployeeInfo();
        bob.PrintEmployeeInfo();

        john.PrintEmployeeInfo();
        ((Manager)jane).PrintEmployeeInfo();
        ((SalesPerson)bob).PrintEmployeeInfo();
    }
}
