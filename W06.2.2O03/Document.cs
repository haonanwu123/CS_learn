public abstract class Document
{
    private static int _nextId = 1;

    public int ID { get; }
    public string Title { get; set; }

    protected Document(string title)
    {
        ID = _nextId++;
        Title = title;
    }

    public abstract void Accept(IDocumentVisitor visitor);
}