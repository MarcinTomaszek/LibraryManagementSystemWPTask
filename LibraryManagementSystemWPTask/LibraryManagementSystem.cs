namespace LibraryManagementSystemWPTask;

public class LibraryManagementSystem
{
    public string UserType { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    
    public User CurrentUser { get; set; }
    public Librarian Librarian { get; set; }
    public LibraryDatabase LibraryDb { get; set; }

    public LibraryManagementSystem()
    {
        LibraryDb = new LibraryDatabase();
    }

    public void Login()
    {
        // Logika logowania
        Console.WriteLine("Logging in...");
    }

    public void Register()
    {
        // Logika rejestracji
        Console.WriteLine("Registering new user...");
    }

    public void Logout()
    {
        // Logika wylogowania
        Console.WriteLine("Logging out...");
        CurrentUser = null;
    }

    // Funkcja wypożyczenia książki
    public void BorrowBook(string title, User user)
    {
        Book book = LibraryDb.ListOfBooks.Find(b => b.Title == title);
        if (book != null && !book.IsBorrowed)
        {
            user.UserAccount.NoBorrowedBooks.Add(book);
            book.IsBorrowed = true;
            book.DueDate = DateTime.Now.AddDays(14); // Załóżmy, że podstawowy termin zwrotu ksiązki to 14 dni
            Console.WriteLine($"Book '{book.Title}' borrowed by {user.Name}. Due date: {book.DueDate.ToShortDateString()}");
        }
        else
        {
            Console.WriteLine(book == null ? "Book not found." : "Book is already borrowed.");
        }
    }
}