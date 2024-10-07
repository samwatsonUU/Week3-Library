
namespace Library
{
    class Book
    {

        private string title;
        private string author;
        private string isbn;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        public string Isbn
        {
            get { return isbn; }
            set { isbn = value; }
        }

        public Book(string bookTitle, string bookAuthor, string bookISBN)
        {

            this.title = bookTitle;
            this.author = bookAuthor;
            this.isbn = bookISBN;

        }

        public void DisplayInfo()
        {

            Console.WriteLine($"Book title: {title}");
            Console.WriteLine($"Book author: {author}");
            Console.WriteLine($"Book ISBN: {isbn}");
            Console.WriteLine("");

        }

    }
}
