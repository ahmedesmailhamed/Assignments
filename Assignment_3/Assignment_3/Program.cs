namespace Assignment_3;

class Program
{
    static void PrintWelcomeMessage()
    {
        System.Console.WriteLine("Welcome to the Library!");
    }
    static void PrintBookTitle(string title){
        System.Console.WriteLine("Book title: " + title);
    }
    static void Main(string[] args)
    {
        #region Q1
        //    double []prices={25.5, 40.0, 33.75};
        //    System.Console.WriteLine(prices[1]);
        #endregion
        #region Q2
//             // Create a 2x2 multidimensional array int[,] shelfCopies where shelf 0 has 3, 5 copies and
// shelf 1 has 1, 4 copies. Print the number of copies on shelf 1, slot 0.
            // int [,] shelfCopies={{3,5},
            //                      {1,4}};
            // System.Console.WriteLine(shelfCopies[1,0]);
        #endregion
        #region Q3
//         Write a method called PrintWelcomeMessage that takes no parameters and prints
// "Welcome to the Library!". Call it from Main.
           // PrintWelcomeMessage();
        #endregion
        #region Q4
//             Write a method PrintBookTitle(string title) that prints "Book title: " + title. Call it with
// "Clean Code".
                PrintBookTitle("Clean Code");
        #endregion
    }
}
