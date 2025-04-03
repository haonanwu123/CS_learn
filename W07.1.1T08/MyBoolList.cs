public class MyBoolList : MyGenericList<bool>
{
    public MyBoolList(List<bool> elems) : base(elems) { }

    public override bool Combine()
    {
        return Elems.All(b => b);
    }
}