namespace LibraryManagementSystemWPTask;

public class Librarian
{
    public string Name { get; set; }
    public string ID { get; set; }
    public string Password { get; set; }

    public void VerifyLibrarian()
    {
        // Weryfikacja bibliotekarza
        Console.WriteLine("Verifying librarian...");
    }

    public void Search(string bookTitle, LibraryDatabase libraryDb)
    {
        // Wyszukiwanie książki
        Console.WriteLine($"Searching for book: {bookTitle}");
        libraryDb.Search(bookTitle);
    }
}