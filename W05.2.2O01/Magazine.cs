public class Magazine : Publication
{
    private string Issue { get; set; }

    public Magazine(string title, string publisher, int pages, string[] audience, string issue)
        : base(title, publisher, "Magazine", pages, audience)
    {
        Issue = issue;
    }

    public override string PublishedOn
    {
        get
        {
            return IsPublished
                ? $"Issue: {Issue}; published on {base.PublishedOn}"
                : "not published yet";
        }
    }

    public override string ToString()
    {
        return $"{Title}, {Pages} pages, {PublishedOn}";
    }
}