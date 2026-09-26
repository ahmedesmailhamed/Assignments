namespace Adv_3;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
         HashSet<string> emails =new HashSet<string>(StringComparer.OrdinalIgnoreCase);

        emails.Add("ahmed@test.com");
        emails.Add("AHMED@test.com");
        emails.Add("sara@test.com");
        emails.Add("Sara@Test.Com");

        Console.WriteLine($"Email Count: {emails.Count}");

        HashSet<int> setA = new HashSet<int> { 1, 2, 3, 4, 5 };
        HashSet<int> setB = new HashSet<int> { 4, 5, 6, 7, 8 };

        HashSet<int> union = new HashSet<int>(setA);
        union.UnionWith(setB);

        Console.WriteLine("Union:");
        Console.WriteLine(string.Join(", ", union));

        HashSet<int> intersection = new HashSet<int>(setA);
        intersection.IntersectWith(setB);

        Console.WriteLine("Intersection:");
        Console.WriteLine(string.Join(", ", intersection));

        HashSet<int> difference = new HashSet<int>(setA);
        difference.ExceptWith(setB);

        Console.WriteLine("Except:");
        Console.WriteLine(string.Join(", ", difference));

        HashSet<int> subset = new HashSet<int> { 1, 2 };

        Console.WriteLine($"{{1, 2}} is subset of Set A: {subset.IsSubsetOf(setA)}");
    }
}