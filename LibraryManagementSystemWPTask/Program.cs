namespace LibraryManagementSystemWPTask;

class Program
{
    static void Main(string[] args)
    {
        LibraryManagementSystem librarySystem = new LibraryManagementSystem();
        
        // Dodanie kilku książek do bazy
        librarySystem.LibraryDb.Add(new Book { Title = "C# Programming", Author = "John Doe", ISBN = "1234567890", Publication = new DateTime(2020, 1, 1) });
        librarySystem.LibraryDb.Add(new Book { Title = "Data Structures", Author = "Jane Smith", ISBN = "0987654321", Publication = new DateTime(2018, 5, 15) });
        
        // Wyświetlenie listy książek
        librarySystem.LibraryDb.Display();
        
        // Wyszukiwanie książki
        librarySystem.LibraryDb.Search("C# Programming");

        // Symulacja logowania i pracy użytkownika
        Student student = new Student { Name = "Adam Kowalski", ID = "S12345", Class = "Informatyka" };
        student.CheckAccount();
        student.GetBookInfo();

        librarySystem.BorrowBook("C# Programming", student);

        // Sprawdzanie konta po wypożyczeniu
        student.CheckAccount();
        student.GetBookInfo();
    }
}