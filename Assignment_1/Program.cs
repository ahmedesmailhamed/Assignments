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
            // Console.WriteLine(book.ToString());
            // System.Console.WriteLine(book.Equals(book));
            // System.Console.WriteLine(book.GetHashCode());
            // System.Console.WriteLine(book.GetType());
        #endregion

        #region Question 3
            /*  Look at the line below. Is it a compile-time error, a runtime error, or a logical error? Fix it.
                Compile-time error — you can't put text (string) into an int variable.
            */
        #endregion
        
        #region Question 4
        //Write code that divides 10 by 0 inside a try block, catches the exception, prints "Cannot divide by zero", and then prints "Done" in a finally block.
        // int num=10;
        // try
        // {
        //     num/=0;
        // }
        // catch
        // {
        //     System.Console.WriteLine("Cannot divide by zero");
        // }
        // finally
        // {
        //     System.Console.WriteLine("Done");
        // }
        #endregion
        
        #region Question 5
            //Declare an int pages = 300; then store it in a double variable without using a cast.
            // int pages=300;
            // double DBpages=pages;
            
        #endregion
        
        #region Question 6
        //Declare a double price = 49.99; then convert it into an int using a cast.
        // double price=49.99;
        // //System.Console.WriteLine(price);
        // price=(int)price;
        // //System.Console.WriteLine(price);
         #endregion

        #region Question 7
        //Given string pagesText = "464";, convert it into an int using the Convert class.
        string pagesText="464";
        Convert.ToInt32(pagesText);
        #endregion

    }
}
