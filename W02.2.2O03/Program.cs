namespace W02._2._2O03;

static class Program
{
    static void Main()
    {
        List<DNA> dnaList = new List<DNA>
        {
            new DNA("ACGT"),
            new DNA("GCTTAC"),
            new DNA("CGTTAGCTT"),
            new DNA("TACA")
        };

        Console.WriteLine("What is the minimum sequence length?");
        int minLength = Convert.ToInt32(Console.ReadLine());

        var filteredSequences = dnaList.Where(dna => dna.Seq.Length >= minLength).ToList();

        Console.WriteLine("The filtered list:");
        foreach (var dna in filteredSequences)
        {
            Console.WriteLine(dna.Seq);
        }
    }
}