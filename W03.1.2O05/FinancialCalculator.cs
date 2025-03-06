class FinancialCalculator
{
    private static FinancialCalculator _instance = null!;
    public readonly Dictionary<string, int> Cache = new Dictionary<string, int>();
    private FinancialCalculator() { }

    public static FinancialCalculator GetInstance()
    {
        _instance ??= new FinancialCalculator();
        return _instance;
    }
    public int CalculateYearsToReachTarget(decimal currentBalance, decimal yearlyDeposit, decimal target)
    {

        decimal yearlyInterestRate = SavingsAccount.YearlyInterestRate;

        string key = $"{currentBalance}-{yearlyDeposit}-{target}-{yearlyInterestRate}";

        if (Cache.TryGetValue(key, out int cachedResult))
        {
            return cachedResult;
        }

        int years = 0;
        while (currentBalance < target)
        {
            currentBalance += yearlyDeposit;
            currentBalance *= (1 + yearlyInterestRate);
            years++;
        }

        Cache[key] = years;
        return years;
    }

    public decimal CalculateYearlyDepositToReachTarget(decimal currentBalance, decimal target, int years)
    {
        decimal remaining = target - currentBalance;

        for (int i = 0; i < years; i++)
        {
            remaining /= (1 + SavingsAccount.YearlyInterestRate);
        }

        decimal deposit = remaining / years;
        return deposit;
    }

    public void Reset()
    {
        Cache.Clear();
    }
}
