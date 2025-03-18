public class SavingsAccount : BankAccount
{
    private bool _locked;

    public SavingsAccount(double initialBalance, double interestRate) : base(initialBalance, interestRate)
    {
        _locked = true;
    }

    public override double Withdraw(double amount)
    {
        if (_locked) return 0;
        return base.Withdraw(amount);
    }

    public override void NextYear()
    {
        YearsPassed++;
        if (YearsPassed < 5)
        {
            ApplyInterest();
        }
        else
        {
            _locked = false;
        }
    }
}