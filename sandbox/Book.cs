public class Book
{
    private string _title;
    private string _author;

    public Book(string title, string author)
    {
        _title = newTitle;
        _author = newAuthor;
        _checkedOutDate = "";

    
    }

    public void CheckOut()
    {
        _checkedOutDate = DateTime.Now.ToString("yyyy-MM-dd");
    }

    public bool IsCheckedOut()
    {
        return _checkedOutDate != "";
    }
    public void Display()
    {
        Console.WriteLine($"{_title} by {_author} checked out on {_checkedOutDate}");
}