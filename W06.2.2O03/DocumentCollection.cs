public class DocumentCollection
{
    private readonly List<Document> _documents = new();

    public void AddDocument(Document document)
    {
        _documents.Add(document);
    }

    public bool RemoveDocumentById(int id)
    {
        var doc = _documents.FirstOrDefault(d => d.ID == id);
        return doc != null && _documents.Remove(doc);
    }

    public void DisplayDocuments()
    {
        foreach (var doc in _documents)
        {
            Console.WriteLine($"{doc.ID}: {doc.Title}");
        }
    }

    public Document? FindDocument(string title)
    {
        return _documents.FirstOrDefault(d => d.Title == title);
    }
}