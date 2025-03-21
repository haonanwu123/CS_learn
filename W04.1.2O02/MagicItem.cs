class MagicItem : Item
{
    public readonly string EffectDescription;

    public MagicItem(Item item, string effectDescription) : base(item.Name, item.Price * 5)
    {
        EffectDescription = effectDescription;
    }

    public MagicItem(string name, int price, string effectDescription) : base(name, price)
    {
        EffectDescription = effectDescription;
    }
}