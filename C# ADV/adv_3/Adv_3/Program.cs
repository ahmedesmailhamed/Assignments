namespace Adv_3;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Stack<string> browserHistory = new Stack<string>();

        browserHistory.Push("google.com");
        browserHistory.Push("github.com");
        browserHistory.Push("stackoverflow.com");
        browserHistory.Push("youtube.com");
        browserHistory.Push("claude.ai");

        Console.WriteLine($"Current Page: {browserHistory.Peek()}");

        Console.WriteLine("\nGoing Back:");

        for (int i = 0; i < 3; i++)
        {
            string page = browserHistory.Pop();
            Console.WriteLine($"Leaving: {page}");
        }

        Console.WriteLine($"\nCurrent Page: {browserHistory.Peek()}");

        bool success = browserHistory.TryPop(out string pageAfterEmpty);

        Console.WriteLine($"\nTryPop succeeded: {success}");

        if (!success)
        {
            Console.WriteLine("Stack is empty.");
        }
    }
}