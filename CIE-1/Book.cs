using System;

namespace _24SOECE213014_AMRITA.CIE_1
{
    internal class Book
    {
        private int bookId;
        private string title;
        private double price;

        public int BookId
        {
            get { return bookId; }
            set { bookId = value; }
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public void Display()
        {
            Console.WriteLine("Book ID: " + bookId);
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Price: " + price);
        }
    }

    class BookDemo
    {
        static void Main(string[] args)
        {
            Book b1 = new Book();
            b1.BookId = 1101;
            b1.Title = "Logic Building";
            b1.Price = 250.00;

            b1.Display();

            Console.ReadLine(); // Keep console open
        }
    }
}
