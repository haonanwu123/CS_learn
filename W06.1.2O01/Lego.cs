class Lego : Toy
{
    public bool IsBuilt { get; private set; } = false;

    public Lego(string name, int minAge) : base(name, minAge, 99) { }

    public void Build() => IsBuilt = true;
    public void Disassemble() => IsBuilt = false;

    public override string ToString() => (IsBuilt ? "Built " : "") + base.ToString();

    public override string AgeSuitability => $"{MinAge}+";
}
