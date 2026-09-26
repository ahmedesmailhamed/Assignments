namespace Adv_3;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
         Dictionary<string, string> phoneBook = new Dictionary<string, string>();

        phoneBook.Add("Ahmed", "01012345678");
        phoneBook.Add("Sara", "01123456789");
        phoneBook.Add("Ali", "01234567890");
        phoneBook.Add("Mona", "01534567890");

        phoneBook["Eslam"] = "01098765432";

        try
        {
            phoneBook.Add("Ahmed", "01111111111");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }

        bool added = phoneBook.TryAdd("Ahmed", "01222222222");
        Console.WriteLine($"TryAdd succeeded: {added}");

        bool exists = phoneBook.ContainsKey("Khaled");
        Console.WriteLine($"Khaled exists: {exists}");

        string phone = phoneBook.GetValueOrDefault("Khaled", "Not Found");
        Console.WriteLine($"Khaled phone: {phone}");

        Console.WriteLine("\nKeys:");
        foreach (string key in phoneBook.Keys)
        {
            Console.Write($"{key} ");
        }

        Console.WriteLine("\n\nValues:");
        foreach (string value in phoneBook.Values)
        {
            Console.Write($"{value} ");
        }
    }
}