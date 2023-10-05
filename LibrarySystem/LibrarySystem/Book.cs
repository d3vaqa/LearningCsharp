public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string ISBN { get; set; }
    public bool IsAvailable { get; set; }

    public void BorrowBook()
    {
        IsAvailable = false;
    }

    public void ReturnBook()
    {
        IsAvailable = true;
    }
}
