namespace LibraryManagementSystemWPTask;

public class User
{
    public string Name { get; set; }
    public string ID { get; set; }
    public Account UserAccount { get; set; }

    public User()
    {
        UserAccount = new Account();
    }

    public void Verify()
    {
        // Weryfikacja użytkownika
        Console.WriteLine("Verifying user...");
    }

    public void CheckAccount()
    {
        // Sprawdzanie konta użytkownika
        Console.WriteLine($"Account status: Borrowed: {UserAccount.NoBorrowedBooks.Count}, Reserved: {UserAccount.NoReservedBooks.Count}, Returned: {UserAccount.NoReturnedBooks.Count}");
    }

    public void GetBookInfo()
    {
        
        // Wypisywanie listy wypożyczonych książek
        foreach (var b in UserAccount.NoBorrowedBooks)
        {
            Console.WriteLine($"{b.Author} {b.Title}" );
        }
    }
}