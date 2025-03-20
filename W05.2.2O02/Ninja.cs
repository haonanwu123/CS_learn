public class Ninja : Fighter
{
    private int _lastAttackDistance = 1;

    public Ninja(string name, Weapon weapon) : base(name, weapon) { }

    public void SetDistance(int distance)
    {
        _lastAttackDistance = distance;
    }

    public override int Attack()
    {
        return Attack(_lastAttackDistance);
    }

    public int Attack(int distance)
    {
        if (MainWeapon == null) return 0;

        if (distance > AttackRange)
        {
            int damage = base.Attack() * 4;
            EquipMainWeapon(null!);
            return damage;
        }
        return base.Attack();
    }
}
