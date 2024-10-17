namespace LibraryManagementSystemWPTask;

public class LibraryDatabase
{
    public List<Book> ListOfBooks { get; set; }

    public LibraryDatabase()
    {
        ListOfBooks = new List<Book>();
    }

    public void Add(Book book)
    {
        // Dodanie książki do bazy danych
        ListOfBooks.Add(book);
        Console.WriteLine($"Book '{book.Title}' added to the database.");
    }

    public void Delete(Book book)
    {
        // Usunięcie książki z bazy danych
        ListOfBooks.Remove(book);
        Console.WriteLine($"Book '{book.Title}' deleted from the database.");
    }

    public void Update(Book book)
    {
        // Aktualizacja informacji o książce
        Console.WriteLine($"Book '{book.Title}' updated.");
    }

    public void Display()
    {
        // Wyświetlenie listy książek
        Console.WriteLine("Available books:");
        foreach (var book in ListOfBooks)
        {
            Console.WriteLine($"{book.Title} by {book.Author}");
        }
    }

    public void Search(string title)
    {
        // Wyszukiwanie książki po tytule
        Book foundBook = ListOfBooks.Find(b => b.Title == title);
        if (foundBook != null)
        {
            Console.WriteLine($"Found: {foundBook.Title} by {foundBook.Author}");
        }
        else
        {
            Console.WriteLine("Book not found.");
        }
    }
}