namespace Adv_3;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> grades = new List<int>
        {
            85, 92, 78, 95, 88, 70, 100, 65
        };

        Console.WriteLine("Grades:");
        Console.WriteLine(string.Join(", ", grades));

        Console.WriteLine($"Count: {grades.Count}");
        Console.WriteLine($"First Grade: {grades[0]}");
        Console.WriteLine($"Last Grade: {grades[grades.Count - 1]}");

        grades.Sort();

        Console.WriteLine("\nSorted Grades:");
        Console.WriteLine(string.Join(", ", grades));

        int firstAbove90 = grades.Find(g => g > 90);
        Console.WriteLine($"\nFirst grade above 90: {firstAbove90}");

        List<int> failingGrades = grades.FindAll(g => g < 75);

        Console.WriteLine("Failing Grades:");
        Console.WriteLine(string.Join(", ", failingGrades));

        grades.RemoveAll(g => g < 75);

        Console.WriteLine("Grades after removing failing grades:");
        Console.WriteLine(string.Join(", ", grades));

        Console.WriteLine($"Any grade equals 100: {grades.Contains(100)}");

        List<string> gradeLabels = grades.ConvertAll(g => $"Grade: {g}");

        Console.WriteLine("Grade Labels:");
        Console.WriteLine(string.Join(", ", gradeLabels));
    }
}