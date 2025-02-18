using System;
using System.Collections.Generic;
using System.Linq;

public class Member // creates a member
{
    public string Name { get; set; } // gets and sets member name
    public int ID { get; set; } // get/set member ID
    private List<Book> BorrowedBooks { get; set; } // list of books checked out by user
 
    public Member(string name, int id) // "bundle" data
    {
        Name = name;
        ID = id;
        BorrowedBooks = new List<Book>();
    }

    public void BorrowBook(Library library, string isbn) // sets borrowed books which includes title and isbn
    {
        Book book = library.GetBook(isbn);
        if (book != null) // more condition checks
        {
            BorrowedBooks.Add(book);
            library.RemoveBook(isbn);
            Console.WriteLine($"{Name} borrowed: {book}");
        }
        else
        {
            Console.WriteLine("Book not available.");
        }
    }

    public void ReturnBook(Library library, string isbn) // book return - removes book and member association 
    {
        Book book = BorrowedBooks.FirstOrDefault(b => b.ISBN == isbn);
        if (book != null)
        {
            BorrowedBooks.Remove(book);
            library.AddBook(book);
            Console.WriteLine($"{Name} returned: {book}");
        }
        else
        {
            Console.WriteLine("Book not found in borrowed list.");
        }
    }

    public void DisplayBorrowedBooks() // displays all books borrowed by id
    {
        Console.WriteLine($"{Name}'s Borrowed Books:");
        foreach (var book in BorrowedBooks)
        {
            Console.WriteLine(book);
        }
    }
}