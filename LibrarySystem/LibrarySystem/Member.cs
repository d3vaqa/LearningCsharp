public class Member
{
    public string Name { get; set; }
    public int MemberID { get; set; }
    public List<Book> BooksBorrowed { get; set; }

    public void BorrowBook(Book book)
    {
        book.BorrowBook();
        BooksBorrowed.Add(book);
    }

    public void ReturnBook(Book book)
    {
        book.ReturnBook();
        BooksBorrowed.Remove(book);
    }
}
