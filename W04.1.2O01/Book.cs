class Book
{
    public int ID;
    public string Title;

    public Book(int id, string title = "Title Unknown")
    {
        ID = id;
        Title = title;
    }

    public string Info()
    {
        return $"ID = {ID}, Title = {Title}";
    }
}