public class Loan
{
    public Book Book { get; set; }
    public Member Member { get; set; }
    public DateTime LoanDate { get; set; }
    public DateTime ReturnDate { get; set; }



    public DateTime CalculateDueDate()
    {
        return LoanDate.AddDays(14); // 2 weeks loan period
    }

    public bool IsOverdue()
    {
        return DateTime.Now > ReturnDate;
    }


    public void NotifyIfOverdue()
    {
        if (IsOverdue())
        {
            Console.WriteLine($"Reminder: The book '{Book.Title}' is overdue. Please return it to the library as soon as possible.");
        }
    }


}
