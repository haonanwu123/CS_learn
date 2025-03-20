public class Publication
{
    public string Title { get; }
    public string Publisher { get; }
    public string PublicationType { get; }
    public int Pages
    {
        get => _pages;
        set => _pages = (value < 1) ? 1 : value;
    }
    private int _pages;
    protected string[] Audience { get; }

    private DateTime _publicationDate;
    public DateTime PublicationDate
    {
        set
        {
            _publicationDate = value;
            IsPublished = true;
        }
    }
    protected bool IsPublished { get; set; } = false;

    public Publication(string title, string publisher, string pubType, int pages, string[] audience)
    {
        Title = title;
        Publisher = publisher;
        PublicationType = pubType;
        Pages = pages;
        Audience = audience;
    }

    public virtual string PublishedOn
    {
        get
        {
            return IsPublished ? _publicationDate.ToString("yyyy-MM-dd") : "not published yet";
        }
    }

    public bool IsSuitableForAudience(string audience)
    {
        foreach (var aud in Audience)
        {
            if (aud.Contains(audience)) return true;
        }
        return false;
    }

    public override string ToString()
    {
        return $"{Title}, {Pages} pages, {PublishedOn}";
    }
}