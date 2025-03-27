class Witch : Fighter, ITransform
{
    public override int MaxHitPoints => 80;

    public int MaxMagicPoints => 100;
    private int _currentMagicPoints;
    public int CurrentMagicPoints
    {
        get => _currentMagicPoints;
        private set => _currentMagicPoints = Math.Clamp(value, 0, MaxMagicPoints);
    }

    public override int AttackPower => (IsTransformed ? 1 : 5) + (MyFamiliar?.Attack ?? 0);

    public Familiar MyFamiliar { get; set; }

    public bool IsTransformed { get; private set; }

    public Witch(string name, Familiar familiar) : base(name)
    {
        MyFamiliar = familiar;
        CurrentMagicPoints = MaxMagicPoints;
    }

    public void Transform()
    {
        if (CurrentMagicPoints < 10)
            return;

        CurrentMagicPoints -= 10;
        IsTransformed = true;
    }

    public void Revert() => IsTransformed = false;

    public void Enchant(List<ITransform> targets)
    {
        int totalMPCost = targets.Count * 10;
        if (CurrentMagicPoints < totalMPCost)
            return;

        CurrentMagicPoints -= totalMPCost;
        foreach (var target in targets)
        {
            target.Transform();
        }
    }

    public void Disenchant(List<ITransform> targets)
    {
        int totalMPCost = targets.Count * 10;
        if (CurrentMagicPoints < totalMPCost)
            return;

        CurrentMagicPoints -= totalMPCost;
        foreach (var target in targets)
        {
            if (target is not Lycanthrope)
            {
                target.Revert();
            }
        }
    }

    public void RecoverMagicPoints(int amount)
    {
        if (amount < 0)
            throw new ArgumentException(
                $"Invalid amount: {amount}. Magic recovered must be non-negative.");
        CurrentMagicPoints += amount;
    }
}