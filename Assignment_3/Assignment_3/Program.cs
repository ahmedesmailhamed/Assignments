using System.Text.RegularExpressions;

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
    static void AddBonusPages(int pages)
    {
        pages+=50;
    }
    static void ApplyDiscount(double[] prices)
    {
        prices[0]-=5;
    }
    static void AddBonusPagesByRef(ref int pages)
    {
        pages+=50;
    }
    static void ReplaceArray( double[] prices)
    {
        prices=new double[]{ 10.0, 12.5, 15.0 };
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
                //PrintBookTitle("Clean Code");
        #endregion
        #region Q5
//             Write a method AddBonusPages(int pages) that adds 50 to pages. Call it with a variable
// int pages = 400; and print pages afterward. What do you expect to see, and why?
           //int pages=400;
            //AddBonusPages(pages);
           // System.Console.WriteLine(pages);
            //the pages not change becuase the function edit a copy  
        #endregion
        #region Q6
//             Write a method ApplyDiscount(double[] prices) that subtracts 5 from prices[0]. Call it
// with double[] prices = { 25.5, 40.0 }; and print prices[0] afterward. What do you expect to
// see, and why?
// double[] prices = { 25.5, 40.0 };
//             ApplyDiscount( prices);
//             System.Console.WriteLine(prices[0]);
            //value of prices[0] changes becuase arrays passed by refrance so the funcition edit the real value not a copy
        #endregion
        #region Q7
//             Rewrite the method from question 5 as AddBonusPagesByRef(ref int pages) using ref.
// Call it and print pages afterward. How is the result different from question 5?  
            // int pages=100;
            // AddBonusPagesByRef(ref  pages);
            // System.Console.WriteLine(pages);
            //Bonus added because pages passed by refrance
        #endregion
        #region Q8
//             Write a method ReplaceArray(ref double[] prices) that replaces prices entirely with a
// new array { 10.0, 12.5, 15.0 }. Call it with your prices array and print prices.Length
// afterward.
             double[] prices = { 25.5, 40.0 };
             ReplaceArray( prices);
            System.Console.WriteLine(prices.Length);
        #endregion
    }
}
