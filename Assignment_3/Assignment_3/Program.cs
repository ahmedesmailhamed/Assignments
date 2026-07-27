using System.Reflection.Metadata.Ecma335;
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
    static void ReplaceArray(ref double[] prices)
    {
        prices=new double[]{ 10.0, 12.5, 15.0 };
    }
   static bool TryGetPrice(string title, out double price)
    {
        if(title=="Clean Code"){price=25.5;
        return true;}
        price=0;
        return false;
    }
    static void PrintBookInfo(string title, int pages = 300)
    {
        System.Console.WriteLine($"title:{title} , pages:{pages}");
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
            //  double[] prices = { 25.5, 40.0 };
            //  ReplaceArray(ref prices);
            // System.Console.WriteLine(prices.Length);
            //with ref keyword we edit the real prices array not a copy from the array
            //without ref we pass a copy from the the ref of the array so when we edit the edit will apply
            //but when you change the whole array the change will apply to the copy of the re
        #endregion
        #region Q9
//             Write a method bool TryGetPrice(string title, out double price) that returns true and sets
// price to 25.5 if title is "Clean Code", otherwise returns false and sets price to 0. Call itand print the price if found
                //  string title="Clean Code";
                //  TryGetPrice( title, out double price);
                //  System.Console.WriteLine(price);
        #endregion
        #region Q10
//             Write a method PrintBookInfo(string title, int pages = 300) where pages is optional. Call
// it once with only a title, and once passing both a title and pages
            // string title="Clean Code";
            //     PrintBookInfo( title,   500);
            //     PrintBookInfo( title);
        #endregion
        #region Q11
//             Using the PrintBookInfo method from the question above, call it by naming the
// parameters, passing pages before title.
            string title="Clean Code";int pages=100;
                PrintBookInfo(pages:pages,title:title);
        #endregion

    }
}
