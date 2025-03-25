class Employee : IPayable
{
    public static int EmployeeCounter = 0;

    public int EmployeeId { get; }
    public string Name { get; set; }
    public double Salary { get; set; }

    public Employee(string name, double salary)
    {
        Name = name;
        Salary = salary;
        EmployeeId = ++EmployeeCounter;
    }

    public string Info => $"ID: {EmployeeId} ({Name}); {Salary}/month";

    public double GetPaymentAmount() => Salary;

}
