public class RangedWeapon : Weapon
{
    public int Range { get; }

    public RangedWeapon(string name, int damage, int range) : base(name, damage)
    {
        Range = range;
    }
}