namespace LibraryManagementSystemWPTask;

public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string ISBN { get; set; }
    public DateTime Publication { get; set; }
    public bool Reserved { get; set; }
    public DateTime DueDate { get; set; }
    public bool IsBorrowed { get; set; }

    public void ShowDueDate()
    {
        // Wyświetlenie terminu zwrotu
        Console.WriteLine($"Due date: {DueDate.ToShortDateString()}");
    }

    public void ReservationStatus()
    {
        // Status rezerwacji
        Console.WriteLine(Reserved ? "Book is reserved." : "Book is available.");
    }

    public void Feedback()
    {
        // Dodanie opinii o książce
        Console.WriteLine("Adding feedback for the book...");
    }

    public void BookRequest()
    {
        // Żądanie wypożyczenia książki
        Console.WriteLine("Requesting the book...");
    }

    public void RenewInfo()
    {
        // Odnowienie wypożyczenia
        Console.WriteLine("Renewing book information...");
    }
}