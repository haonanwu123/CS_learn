class Book
{
    public int ID { get; }
    public string Title { get; set; }

    public Book(int id, string title)
    {
        ID = id;
        Title = title;
    }

    public string Info() => $"ID: {ID}, title: {Title}";
}