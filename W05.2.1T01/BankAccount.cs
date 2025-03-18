public class BankAccount
{
    private double _balance;
    protected int YearsPassed;
    protected double InterestRate;

    public BankAccount(double initialBalance, double interestRate)
    {
        _balance = initialBalance;
        InterestRate = interestRate;
        YearsPassed = 0;
    }

    public double ReadBalance()
    {
        return _balance;
    }

    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            _balance += amount;
        }
    }

    public virtual double Withdraw(double amount)
    {
        if (amount < 0) return 0;
        if (SufficientBalance(amount))
        {
            _balance -= amount;
            return amount;
        }
        return 0;
    }

    private bool SufficientBalance(double amount)
    {
        return _balance >= amount;
    }

    public virtual void NextYear()
    {
        ApplyInterest();
        YearsPassed++;
    }

    protected void ApplyInterest()
    {
        _balance += _balance * InterestRate;
    }
}