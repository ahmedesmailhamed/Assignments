namespace Assignment_1;

class Program
{
    /*
    The four universal methods
        to_string (),GetType()
        Equle()->check the reference of two objects && if variables are of value type it will check the value of two variables
        getHashCode()-> help in direct access in map & hashtables
        if(equles)true then HashCodeIsTheSame, Must override if Equals is overridden. 

    Convert String To number
    Parse()       ,   TryParse()    
    throw Exption ,  return false
     */

    class Book
    {
        string Title;
        int Pages;
    }
    static void Main(string[] args)
    {
        #region Question 1
            // //Create a Book class with a Title (string) and Pages (int).
            // //Create a Book object and store it in a variable of type object. Print it.
            object book =new Book();
            //Console.WriteLine(book);//automatic Tostring()
        #endregion

        #region Question 2
            //Using the Book class above,
            //  print the result of calling ToString(), Equals() (compare book with itself), GetHashCode(), and GetType() on book.
            Console.WriteLine(book.ToString());
            System.Console.WriteLine(book.Equals(book));
            System.Console.WriteLine(book.GetHashCode());
            System.Console.WriteLine(book.GetType());
        #endregion
    }
}
