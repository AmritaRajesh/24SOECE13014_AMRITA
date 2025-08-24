using System;
using System.Collections.Generic;

public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public bool IsBorrowed { get; set; }

    public Book(string title, string author)
    {
        Title = title;
        Author = author;
        IsBorrowed = false;
    }
}

public class Library
{
    private Dictionary<string, Book> books = new Dictionary<string, Book>();

    public void AddBook(string title, string author)
    {
        if (!books.ContainsKey(title))
        {
            books.Add(title, new Book(title, author));
            Console.WriteLine($"Book '{title}' added successfully.");
        }
        else
        {
            Console.WriteLine($"Book '{title}' already exists in the library.");
        }
    }

    public void ViewBooks()
    {
        if (books.Count == 0)
        {
            Console.WriteLine("No books in the library.");
        }
        else
        {
            foreach (var book in books.Values)
            {
                Console.WriteLine($"Title: {book.Title}");
                Console.WriteLine($"Author: {book.Author}");
                Console.WriteLine($"Status: {(book.IsBorrowed ? "Borrowed" : "Available")}");
                Console.WriteLine("------------------------");
            }
        }
    }

    public void BorrowBook(string title)
    {
        if (books.ContainsKey(title) && !books[title].IsBorrowed)
        {
            books[title].IsBorrowed = true;
            Console.WriteLine($"Book '{title}' borrowed successfully.");
        }
        else if (!books.ContainsKey(title))
        {
            Console.WriteLine($"Book '{title}' not found in the library.");
        }
        else
        {
            Console.WriteLine($"Book '{title}' is currently borrowed.");
        }
    }

    public void ReturnBook(string title)
    {
        if (books.ContainsKey(title) && books[title].IsBorrowed)
        {
            books[title].IsBorrowed = false;
            Console.WriteLine($"Book '{title}' returned successfully.");
        }
        else if (!books.ContainsKey(title))
        {
            Console.WriteLine($"Book '{title}' not found in the library.");
        }
        else
        {
            Console.WriteLine($"Book '{title}' is already available.");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Library library = new Library();

        while (true)
        {
            Console.WriteLine("Library Book Management System");
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. View Books");
            Console.WriteLine("3. Borrow Book");
            Console.WriteLine("4. Return Book");
            Console.WriteLine("5. Exit");

            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter book title: ");
                    string title = Console.ReadLine();
                    Console.Write("Enter book author: ");
                    string author = Console.ReadLine();
                    library.AddBook(title, author);
                    break;
                case 2:
                    library.ViewBooks();
                    break;
                case 3:
                    Console.Write("Enter book title to borrow: ");
                    string borrowTitle = Console.ReadLine();
                    library.BorrowBook(borrowTitle);
                    break;
                case 4:
                    Console.Write("Enter book title to return: ");
                    string returnTitle = Console.ReadLine();
                    library.ReturnBook(returnTitle);
                    break;
                case 5:
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}