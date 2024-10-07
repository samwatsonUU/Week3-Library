﻿
namespace Library
{
    class Book
    {

        string Title;
        string Author;
        string ISBN;

        public Book(string bookTitle, string bookAuthor, string bookISBN)
        {

            Title = bookTitle;
            Author = bookAuthor;
            ISBN = bookISBN;

        }

        public void DisplayInfo()
        {

            Console.WriteLine($"Book title: {Title}");
            Console.WriteLine($"Book author: {Author}");
            Console.WriteLine($"Book ISBN: {ISBN}");
            Console.WriteLine("");

        }

    }
}
