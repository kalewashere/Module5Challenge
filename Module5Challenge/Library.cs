using System;
using System.Collections.Generic;
using System.Linq;

public class Library
{
    public string Name { get; set; }
    private List<Book> Books { get; set; } // list to fill with book examples

    public Library(string name) // setting up "library" - a dynamic list
    {
        Name = name;
        Books = new List<Book>();
    }

    public void AddBook(Book book) // adding book to library
    {
        Books.Add(book);
        Console.WriteLine($"Added: {book}");
    }

    public bool RemoveBook(string isbn) // adding ISBN 
    {
        Book bookToRemove = Books.FirstOrDefault(b => b.ISBN == isbn);
        if (bookToRemove != null) // condition check for invaild input
        {
            Books.Remove(bookToRemove); // removes book 
            Console.WriteLine($"Removed: {bookToRemove}"); // confirming removal
            return true; // return value set to true
        }
        Console.WriteLine("Book not found."); // confirm book not found
        return false;
    }

    public void DisplayAvailableBooks() // displays all books with foreach loop
    {
        Console.WriteLine("Available Books:");
        foreach (var book in Books)
        {
            Console.WriteLine(book);
        }
    }

    public Book GetBook(string isbn)
    {
        return Books.FirstOrDefault(b => b.ISBN == isbn);
    }
}