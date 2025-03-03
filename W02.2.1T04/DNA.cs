class DNA
{
    public string Seq { get; private set; }

    public DNA(string seq)
    {
        Seq = seq;
    }

    public DNA Replicate1()
    {
        return new DNA(Seq);
    }

    public DNA Replicate2()
    {
        return this;
    }

    public void Mutate(string newSeq)
    {
        Seq = newSeq;
    }
}