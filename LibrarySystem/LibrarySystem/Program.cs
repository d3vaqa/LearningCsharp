class Program
{
    static void Main(string[] args)
    {
        // Creating some books
        Book book1 = new Book { Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", ISBN = "9780743273565", IsAvailable = true };
        Book book2 = new Book { Title = "To Kill a Mockingbird", Author = "Harper Lee", ISBN = "9780061120084", IsAvailable = true };

        // Creating a member
        Member member = new Member { Name = "John Doe", MemberID = 1, BooksBorrowed = new List<Book>() };

        // Borrowing books
        Console.WriteLine($"{member.Name} is borrowing {book1.Title}...");
        member.BorrowBook(book1);

        Console.WriteLine($"{member.Name} is borrowing {book2.Title}...");
        member.BorrowBook(book2);

        // Displaying borrowed books
        Console.WriteLine($"\n{member.Name} has borrowed the following books:");
        foreach (var book in member.BooksBorrowed)
        {
            Console.WriteLine($"- {book.Title} by {book.Author}");
        }

        // Returning a book
        Console.WriteLine($"\n{member.Name} is returning {book1.Title}...");
        member.ReturnBook(book1);

        // Displaying borrowed books after returning
        Console.WriteLine($"\n{member.Name} has now borrowed the following books:");
        foreach (var book in member.BooksBorrowed)
        {
            Console.WriteLine($"- {book.Title} by {book.Author}");
        }


        // Creating a loan
        Loan loan = new Loan { Book = book1, Member = member, LoanDate = DateTime.Now.AddDays(-15), ReturnDate = DateTime.Now.AddDays(-1) };

        // Check and notify if the book is overdue
        loan.NotifyIfOverdue();

        Console.ReadLine(); // Keeping the console open


        Console.ReadLine(); // Keeping the console open
    }
}
