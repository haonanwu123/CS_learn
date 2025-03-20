public class Book : Publication
{
    public string ISBN { get; }
    public string Author { get; }
    public double Price { get; private set; }
    public string Currency { get; private set; } = "EUR";

    public Book(string isbn, string title, string publisher, int pages, string author, string[] audience, double price)
        : base(title, publisher, "Book", pages, audience)
    {
        ISBN = isbn;
        Author = author;
        Price = price;
    }

    public void SetPriceAndCurrency(double price, string currency)
    {
        if (price > 0)
        {
            Price = price;
            Currency = currency;
        }
    }

    public bool IsSuitableForChild()
    {
        return IsSuitableForAudience("Children");
    }

    public override string ToString()
    {
        return $"{Author}, ISBN: {ISBN}, {Title}, {Pages} pages, {PublishedOn}, {Currency} {Math.Floor(Price)}";
    }
}