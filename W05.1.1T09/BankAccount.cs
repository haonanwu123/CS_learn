public class BankAccount
{
    private double _balance;

    public BankAccount(double initialBalance)
    {
        _balance = initialBalance;
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

    public double Withdraw(double amount)
    {
        if (amount < 0) return 0;
        if (SufficientBalance(amount))
        {
            _balance -= amount;
        }
        return 0;
    }

    private bool SufficientBalance(double amount)
    {
        return _balance >= amount;
    }
}