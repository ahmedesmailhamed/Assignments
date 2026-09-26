namespace Adv_3;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
         Queue<string> printQueue = new Queue<string>();

        printQueue.Enqueue("Report.pdf");
        printQueue.Enqueue("Invoice.pdf");
        printQueue.Enqueue("Letter.docx");
        printQueue.Enqueue("Resume.pdf");
        printQueue.Enqueue("Photo.jpg");

        Console.WriteLine("Queue:");

        foreach (string document in printQueue)
        {
            Console.WriteLine(document);
        }

        Console.WriteLine($"Count: {printQueue.Count}");

        Console.WriteLine($"\nNext document: {printQueue.Peek()}");

        Console.WriteLine("\nProcessing Queue:");

        while (printQueue.Count > 0)
        {
            string document = printQueue.Dequeue();
            Console.WriteLine($"Printing: {document}");
        }

        bool success = printQueue.TryDequeue(out string nextDocument);

        Console.WriteLine($"\nTryDequeue succeeded: {success}");

        if (!success)
        {
            Console.WriteLine("Queue is empty.");
        }
    }
}