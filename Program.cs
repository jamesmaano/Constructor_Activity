using System;

public class Book
{
    private string _title;
    private string _author;
    private int _yearPublished;
    private string _genre;

    public Book()
    {
        _title = "Unknown";
        _author = "Unknown";
        _yearPublished = 0;
        _genre = "Unknown";
    }

    public Book(string title, string author)
    {
        _title = title;
        _author = author;
        _yearPublished = 0;
        _genre = "Unknown";
    }

    public Book(string title, string author, int yearPublished)
    {
        _title = title;
        _author = author;
        _yearPublished = yearPublished;
        _genre = "Unknown";
    }

    public Book(string title, string author, int yearPublished, string genre)
    {
        _title = title;
        _author = author;
        _yearPublished = yearPublished;
        _genre = genre;
    }

    public void DisplayBookInfo()
    {
        Console.WriteLine("Title: " + _title);
        Console.WriteLine("Author: " + _author);
        Console.WriteLine("Year Published: " + _yearPublished);
        Console.WriteLine("Genre: " + _genre);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- Book 1: Default Constructor ---");
        Book book1 = new Book();
        book1.DisplayBookInfo();

        Console.WriteLine("\n--- Book 2: Basic Constructor ---");
        Book book2 = new Book("To Kill a Mockingbird", "Harper Lee");
        book2.DisplayBookInfo();

        Console.WriteLine("\n--- Book 3: Detailed Constructor ---");
        Book book3 = new Book("1984", "George Orwell", 1949);
        book3.DisplayBookInfo();

        Console.WriteLine("\n--- Book 4: Complete Constructor ---");
        Book book4 = new Book("The Hobbit", "J.R.R. Tolkien", 1937, "Fantasy");
        book4.DisplayBookInfo();
    }
}
