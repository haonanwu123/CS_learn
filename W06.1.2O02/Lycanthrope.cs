class Lycanthrope : Fighter, ITransform
{
    public override int MaxHitPoints
    {
        get => IsTransformed ? base.MaxHitPoints * 2 : base.MaxHitPoints;
        protected set => base.MaxHitPoints = value;
    }

    public override int AttackPower => IsTransformed ? base.AttackPower * 2 : base.AttackPower;

    public bool IsTransformed { get; private set; }

    public Lycanthrope(string name) : base(name) { }

    public void Transform()
    {
        if (!World.IsDayTime)
        {
            IsTransformed = true;
            CurrentHitPoints = MaxHitPoints;
        }
    }

    public void Revert()
    {
        IsTransformed = false;
    }
}