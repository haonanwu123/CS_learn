using System.Dynamic;

class Library
{
    public List<Book> Books { get; }
    public int MaxSize { get; }

    public Library(int maxSize)
    {
        MaxSize = maxSize;
        Books = new List<Book>();
    }

    public bool AddBook(int id, string title)
    {
        if (Books.Count() >= MaxSize)
        {
            return false;
        }

        Books.Add(new Book(id, title));
        return true;
    }

    public Book? FindBookByID(int id)
    {
        return Books.FirstOrDefault(book => book.ID == id);
    }

    public void EditBookTitle(int id, string newTitle)
    {
        Book? book = FindBookByID(id);
        if (book != null)
        {
            book.Title = newTitle;
        }
    }

    public void RemoveBookByTitle(string title)
    {
        Books.RemoveAll(book => book.Title == title);
    }
}