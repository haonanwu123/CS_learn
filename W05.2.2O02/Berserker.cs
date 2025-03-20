public class Berserker : Fighter
{
    private Weapon _secondaryWeapon;

    public Berserker(string name, Weapon mainWeapon, Weapon secondaryWeapon) : base(name, mainWeapon)
    {
        _secondaryWeapon = secondaryWeapon;
    }

    public override void EquipMainWeapon(Weapon weapon)
    {
        base.EquipMainWeapon(weapon);
    }

    public override int Attack()
    {
        int totoalDamge = base.Attack() + (_secondaryWeapon?.Damage ?? 0) + BaseAttack;

        if (HP > 20)
        {
            HP -= 20;
            return totoalDamge * 2;
        }
        else
        {
            return totoalDamge;
        }
    }
}