public class Ranger : Fighter
{
    private int _arrows;

    public Ranger(string name, RangedWeapon rangedWeapon, int arrows) : base(name, rangedWeapon)
    {
        _arrows = arrows;
    }

    public override void EquipMainWeapon(Weapon weapon)
    {
        if (weapon is RangedWeapon)
        {
            MainWeapon = weapon;
        }
        else
        {
            base.EquipMainWeapon(weapon);
        }
    }

    public override int Attack()
    {
        if (MainWeapon is RangedWeapon && _arrows > 0)
        {
            _arrows--;
            return base.Attack();
        }
        else
        {
            return (int)(base.Attack() * 0.75);
        }
    }

    public override int AttackRange => MainWeapon is RangedWeapon rangedWeapon ? rangedWeapon.Range : base.AttackRange;
}