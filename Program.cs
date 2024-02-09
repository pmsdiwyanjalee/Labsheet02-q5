using System;
using System.Collections.Generic;

class LibraryBook
{
    public string Title { get; set; }
    public string Author { get; set; }
    public bool Available { get; set; }

    public LibraryBook(string title, string author)
    {
        Title = title;
        Author = author;
        Available = true;
    }

    public void BorrowBook()
    {
        if (Available)
        {
            Available = false;
            Console.WriteLine($"Book '{Title}' by {Author} has been borrowed.");
        }
        else
        {
            Console.WriteLine($"Book '{Title}' by {Author} is not available.");
        }
    }
}

class LibrarySystem
{
    private List<LibraryBook> books = new List<LibraryBook>();

    public void AddBook(LibraryBook book)
    {
        books.Add(book);
    }

    public void DisplayLibraryStatus()
    {
        Console.WriteLine("\nLibrary Status:");
        foreach (var book in books)
        {
            Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Available: {(book.Available ? "Yes" : "No")}");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        LibrarySystem library = new LibrarySystem();

        library.AddBook(new LibraryBook("The Great Gatsby", "F. Scott Fitzgerald"));
        library.AddBook(new LibraryBook("To Kill a Mockingbird", "Harper Lee"));
        library.AddBook(new LibraryBook("1984", "George Orwell"));

        library.DisplayLibraryStatus();

        library.books[0].BorrowBook();

        library.DisplayLibraryStatus();

        library.books[0].BorrowBook();
    }
}
