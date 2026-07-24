using System.Text;

namespace Assignment_2;

class Program
{
    static void Main(string[] args)
    {
        #region Qusetion1
        //         Declare string title = "clean code";. Call title.ToUpper() and store it in a new variable upperTitle. Print
// both title and upperTitle to show that title did not change.
            // string title="clean code";
            // string upperTitle=title.ToUpper();
            // System.Console.WriteLine(title);
            // System.Console.WriteLine(upperTitle);            
        #endregion
        #region Question2
//             Declare two separate string variables, both set to the literal "Clean Code". Use ReferenceEquals()
// to check if they point to the same object in memory.
                // string s1="Clean Code",s2="Clean Code";
                // if(ReferenceEquals(s1,s2))System.Console.WriteLine("Equal");
                // else System.Console.WriteLine("Nor Equal");
        #endregion
        #region Question3
            //Create a StringBuilder, Append() the text "Book List", then Append() " - Updated" onto the same
// object. Print the final result.
            StringBuilder bookList=new StringBuilder();
            bookList.Append("Book List");
            bookList.Append(" - Updated");
            System.Console.WriteLine(bookList);
        #endregion

    }
}
