using System.Collections.Concurrent;

namespace Ass4;

enum Genre { Fiction, NonFiction, Science };
class Book
{
    private string password="secret";
    internal int copiesInStock = 5;
    public string Title="C#";
    public Genre genre { get; set; }

}
class Program
{
    static void Main(string[] args)
    {
        #region Q1
            //Q1: Add a private string password = "secret";
        //  field to a Book class. Try to print it from Main (outside the class). What happens, and why?
        Book book=new Book();
        //System.Console.WriteLine(book.password);
        //compile erroe ,private mean the field is avaliable in the class only
        #endregion
        
        #region Q2
            //Q2
        //Add an internal int copiesInStock = 5;
        //  field to Book. Print it from Main. Does it compile?Why?
       //System.Console.WriteLine(book.copiesInStock);
       //it's compiled because internal can be accessed in same project (the same assembly code)
        #endregion

        #region Q3
            //System.Console.WriteLine(book.Title);
        #endregion
        
        #region Q4
        // Declare an enum Genre { Fiction, NonFiction, Science }.
// Add a Genre property to Book, assign it Genre.Science, and print it.
        book.genre=Genre.Science;
        //System.Console.WriteLine(book.genre);
        #endregion

        #region Q5
            // Using the Genre enum above, print the underlying int value of
// Genre.Fiction, Genre.NonFiction, and Genre.Science by casting each to int.
            // System.Console.WriteLine((int)Genre.Fiction);
            // System.Console.WriteLine((int)Genre.NonFiction);
            // System.Console.WriteLine((int)Genre.Science);
        #endregion

        #region Q6
        // Given int genreNumber = 1;, cast it into a Genre value and print the result.
        // int genreNumber = 1;
        // Genre value=(Genre)genreNumber;
        // System.Console.WriteLine(value);
        #endregion

        #region Q7
            //Given Genre genre = Genre.Fiction;
            // , convert it into a string using ToString() and print it.
            Genre genre = Genre.Fiction;
            System.Console.WriteLine(genre.ToString());
        #endregion
    }
}
