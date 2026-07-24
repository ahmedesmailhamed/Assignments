using System.Runtime.ConstrainedExecution;
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
            // StringBuilder bookList=new StringBuilder();
            // bookList.Append("Book List");
            // bookList.Append(" - Updated");
            // System.Console.WriteLine(bookList);
        #endregion
        #region Question4
        //Using the StringBuilder from the question above, use Replace() to change "Book List" into "Library".
//Print the result.
        // bookList.Replace("Book List","Library");
        // System.Console.WriteLine(bookList);
        #endregion

        #region Question 5
        //Given string title = "Clean Code"; and int pages = 464;, build the sentence "Book: Clean Code,
// Pages: 464" using the + operator.
            // string title ="Clean Code";
            // int pages=464;
            // System.Console.WriteLine("Book: "+title+", Pages; "+pages);
        #endregion
        #region Question 6

         //   System.Console.WriteLine($"Book: {title}, Pages: {pages}");
        #endregion
        #region Question 7
       // System.Console.WriteLine(string.Format("Book: {0}, Pages: {1}",title ,pages));
        #endregion
        #region Question 8
        //Given int pages = 464;, write an if / else statement that prints "Long Book" if pages is greater than
//300, otherwise prints "Short Book".
            // int pages=464;
            // if(pages>300)System.Console.WriteLine("Long Book");
            // else System.Console.WriteLine("Short Book");
        #endregion
        #region Question 9
        //Given int pages = 464; and bool isAvailable = true;, print "You can borrow this book" only if pages is
//greater than 300 and isAvailable is true. Use the && operator.
            // int pages=464; bool isAvailable=true;
            // if(pages>300&&isAvailable)System.Console.WriteLine("You can borrow this book");
        #endregion
        #region Question 10
//         Given string title = "Refactoring";, write a switch statement that prints "Great choice!" if the title is
// "Clean Code", "Nice pick!" if it's "Refactoring", and "Never heard of it" for anything else.
        //     string title="Refactoring";
        // switch (title)
        // {
        //     case "Clean Code":System.Console.WriteLine("Great choice!"); break;
        //     case "Refactoring":System.Console.WriteLine("Nice pick!");break;
        //     default :System.Console.WriteLine("NativeOverlapped heard of it");break;
        // }
        #endregion
        #region Question11
//             Given int pages = 464;, use the ternary operator to store "Long Book" or "Short Book" into a
// variable sizeLabel (same rule as question 8: long if pages > 300).
            // int pages=464;
            // string sizeLabel=(pages>300?"Long Book":"Short Book");
            // System.Console.WriteLine(sizeLabel);
        #endregion
        #region Question 12
//             //Given string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };, use a for loop
// to print each book with its position number, like 1. Clean Code.
             string []books={ "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            // for(int i = 0; i < 3; i++)
            // {
            //     System.Console.WriteLine(books[i]+" "+(i+1));
            // }
        #endregion
        #region Question 13
            // Using the same books array, use a while loop to print every book title.
        //     int cnt=0;
        // while (cnt<3)
        // {
        //     System.Console.WriteLine(books[cnt]);
        //     cnt++;
        // }
        #endregion

        #region Question 14
            //Write a do-while loop that prints "Checking book..." exactly 3 times.
        //     int cnt=2;
        // do
        // {
        //     System.Console.WriteLine("Checking book...");
        //     cnt--;
        // }while(cnt>=0);
        #endregion

        #region Question 15
            //Using the same books array, use a foreach loop to print every book title.
            //foreach(string title in books)System.Console.WriteLine(title);
        #endregion

        #region Question 16
//             Using the same books array, loop through it and print each title, but stop completely (break) once
// you reach "Refactoring".
            foreach(string title in books)
        {
            if(title =="Refactoring")break;
            System.Console.WriteLine(title);
        }
        #endregion
    }
}
