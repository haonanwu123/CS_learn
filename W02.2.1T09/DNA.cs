class DNA
{
    private static Random _rand = new(0); // Seeded Random

    public DNA Ancestor { get; set; }
    public string Seq { get; set; }

    public DNA(DNA ancestor, string seq)
    {
        Ancestor = ancestor;
        Seq = seq;
    }

    public DNA Replicate()
    {
        string mutatedSeq = MutateTransition();
        return new DNA(this, mutatedSeq);
    }

    private string MutateTransition()
    {
        int indexToMutate = _rand.Next(0, Seq.Length);
        string mutatedSeq = Seq[0..indexToMutate] // Left of mutation
            + MutateTransitionTable(Seq[indexToMutate]) // Mutation
            + Seq[(indexToMutate + 1)..Seq.Length]; // Right of mutation
        return mutatedSeq;
    }

    private static char MutateTransitionTable(char nucleotide) => nucleotide switch
    {
        'A' => 'G',
        'G' => 'A',
        'C' => 'T',
        'T' => 'C',
        _ => throw new ArgumentOutOfRangeException($"{nucleotide}", $"Unexpected nucleotide value: {nucleotide}"),
    };
}
