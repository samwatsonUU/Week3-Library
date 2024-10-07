
class Book
{

    String Title;
    string Author;
    string ISBN;

    void DisplayInfo()
    {

        Console.WriteLine($"Book title: {Title}");
        Console.WriteLine($"Book author: {Author}");
        Console.WriteLine($"Book ISBN: {ISBN}");
        Console.WriteLine("");

    }
    static void Main(String[] args)
    {

        Book book = new Book();

        book.Title = "C# for beginners";
        book.Author = "Bill Gates";
        book.ISBN = "12345678";

        Book book1 = new Book();

        book1.Title = "OOP";
        book1.Author = "Sam Watson";
        book1.ISBN = "9101111213";

        book.DisplayInfo();
        book1.DisplayInfo();

    }


}