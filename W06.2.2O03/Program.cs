namespace W06._2._2O03;

public class Program
{
    public static void Main()
    {
        var collection = new DocumentCollection();
        collection.AddDocument(new TextDocument("Note", "Simple text"));
        collection.AddDocument(new ImageDocument("Photo", "/images/1.jpg"));

        var visitor = new DocumentVisitor();
        foreach (var doc in new Document[]
        {
            new TextDocument("Report", "This is a long document body"),
            new AudioDocument("Recording", 120)
        })
        {
            doc.Accept(visitor);
        }
    }
}
