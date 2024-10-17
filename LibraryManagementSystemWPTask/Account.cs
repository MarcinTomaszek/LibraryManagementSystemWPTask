namespace LibraryManagementSystemWPTask;

public class Account
{
    public List<Book> NoBorrowedBooks = new List<Book>();
    public List<Book> NoReservedBooks = new List<Book>();
    public List<Book> NoReturnedBooks = new List<Book>();
    public List<Book> NoLostBooks = new List<Book>();
    public decimal FineAmount { get; set; }

    public void CalculateFine()
    {
        FineAmount = NoLostBooks.Count * 10;
        Console.WriteLine($"Total fine amount: {FineAmount:C}");
    }
}