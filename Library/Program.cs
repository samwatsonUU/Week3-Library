
using Library;

class Program
{

    static void Main(String[] args)
    {

        Book samsBook = new Book("Sam's Book", "Sam Watson", "77777");
        samsBook.DisplayInfo();

        Book samsSecondBook = new Book("Sam's Second Book", "Sam Watson", "10101213");
        samsSecondBook.DisplayInfo();

        Member sam = new Member(01, 73755060, "Sam", "Ardstraw");
        sam.DisplayMemberInfo();

        Member rachael = new Member(02, 784949, "Rachael", "Eglinton");
        rachael.DisplayMemberInfo();

    }

}
