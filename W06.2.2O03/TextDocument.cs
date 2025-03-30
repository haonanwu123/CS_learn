public class TextDocument : Document
{
    public string Body { get; set; }

    public TextDocument(string title, string body) : base(title)
    {
        Body = body;
    }

    public override void Accept(IDocumentVisitor visitor)
    {
        Console.WriteLine(Body.Split(' ').Length <= 10 ?
            "Processing short document..." : "Processing long document...");
        visitor.Visit(this);
    }
}