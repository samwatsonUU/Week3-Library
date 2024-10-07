
using Library;

class Program
{

    static void Main(String[] args)
    {

        Book samsBook = new Book("Sam's Book", "Sam Watson", "77777");
        samsBook.DisplayInfo();

        Book samsSecondBook = new Book("Sam's Second Book", "Sam Watson", "10101213");
        samsSecondBook.DisplayInfo();

    }

}
