class Library
{
    public List<Book> Books { get; set; }

    public Library(List<Book> books = null!)
    {
        Books = books ?? new List<Book>();
    }

    public void AddBook(Book book)
    {
        Books.Add(book);
    }

    public void AddBook(int id, string title)
    {
        Books.Add(new Book(id, title));
    }

    public Book? FindBook(int id)
    {
        foreach (var book in Books)
        {
            if (book.ID == id)
            {
                return book;
            }
        }
        return null;
    }

    public Book? FindBook(string id)
    {
        try
        {
            int idInt = int.Parse(id);
            return FindBook(idInt);
        }
        catch (FormatException)
        {
            Console.WriteLine($"ID = {id}: invalid. The input string '{id}' was not in a correct format.");
            return null;
        }
    }

}