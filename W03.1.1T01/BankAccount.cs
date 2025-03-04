class BankAccount
{
    public static double InterestPercentage = 0.0;
    public double Balance = 0.0;

    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            Balance += amount;
        }
    }

    public void ApplyInterest()
    {
        double interestRate = InterestPercentage / 100;
        Balance += Balance * interestRate;
    }
}