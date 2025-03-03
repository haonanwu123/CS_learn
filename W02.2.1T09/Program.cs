namespace W02._2._1T09;

static class Program
{
    static void Main()
    {
        DNA ancestor = new(null!, "acgt".ToUpper());
        List<DNA> dnaLine = [ancestor];
        for (int i = 0; i < 25; i++)
        {
            ancestor = ancestor.Replicate();
            dnaLine.Add(ancestor);
        }

        while (ancestor.Ancestor != null)
        {
            Console.WriteLine(ancestor.Ancestor.Seq);
            ancestor = ancestor.Ancestor;
        }
    }
}

