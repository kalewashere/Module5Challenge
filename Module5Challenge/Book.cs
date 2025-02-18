public class Book // class accessible by code in Module5Challenege, was getting errors due to acciedentally placing outside of folder (oops)
{
    public string Title { get; set; } // getters and setters - activates portions of code to retrieve data/values
    public string Author { get; set; }
    public string ISBN { get; set; }

    public Book(string title, string author, string isbn)
    {
        Title = title;
        Author = author;
        ISBN = isbn;
    }

    public override string ToString() // tostring method
    {
        return $"{Title} by {Author} (ISBN: {ISBN})";
    }
}