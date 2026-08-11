namespace Ass4;
class Book
{
    private string password="secret";
}
class Program
{
    static void Main(string[] args)
    {
        // Add a private string password = "secret";
        //  field to a Book class. Try to print it from Main (outside the class). What happens, and why?
        Book book=new Book();
        System.Console.WriteLine(book.password);
        //compile erroe ,private mean the field is avaliable in the class only
    }
}
