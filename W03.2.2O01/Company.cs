class Company
{
    public List<Employee> Employees;
    public int WhatIsConsideredDistant;
    public int ExtraTravelAllowanceBudget;
    public int MaxExtraTravelAllowance;
    public string LogLocation;
    public Company()
    {
        Employees = new List<Employee>();
        WhatIsConsideredDistant = 25;
        ExtraTravelAllowanceBudget = 300;
        MaxExtraTravelAllowance = 100;
        LogLocation = "./Log.txt";
    }

    public void Hire(Employee employee) => Employees.Add(employee);

    public void PayMonthlySalary()
    {
        int howManyDistantEmployees = HowManyDistantEmployees();
        foreach (var employee in Employees)
        {
            int payout = employee.Salary + CalculateTravelAllowance(employee, howManyDistantEmployees);
            employee.SalaryEarned += payout;
        }
    }

    private int CalculateTravelAllowance(Employee employee, int howManyDistantEmployees)
    {
        var howManyCloseEmployees = Employees.Count - howManyDistantEmployees;

        var standardTravelAllowance = employee.DistanceFromCompany * 10;

        if (howManyDistantEmployees == 0)
        {
            if (howManyCloseEmployees > 0)
            {
                var extraTravelAllowanceClose = ExtraTravelAllowanceBudget / howManyCloseEmployees;
                return standardTravelAllowance + Math.Min(extraTravelAllowanceClose, 100);
            }
            else
            {
                return standardTravelAllowance;
            }
        }
        else
        {
            var extraTravelAllowanceDistant = Math.Min(ExtraTravelAllowanceBudget / howManyDistantEmployees, MaxExtraTravelAllowance);

            var extraTravelAllowanceClose = 0;
            if (howManyCloseEmployees > 0)
            {
                extraTravelAllowanceClose = Math.Min((ExtraTravelAllowanceBudget - extraTravelAllowanceDistant * howManyDistantEmployees) / howManyCloseEmployees, 100);
            }
            return standardTravelAllowance +
                   (employee.DistanceFromCompany >= WhatIsConsideredDistant ?
                   extraTravelAllowanceDistant : extraTravelAllowanceClose);
        }
    }


    private int HowManyDistantEmployees()
    {
        int howMany = 0;
        foreach (var employee in Employees)
        {
            if (employee.DistanceFromCompany >= WhatIsConsideredDistant)
                howMany++;
        }
        return howMany;
    }

    private void LogException(string message)
    {
        try
        {
            File.AppendAllText(LogLocation, DateTime.Now + "\n" + message + "\n");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}