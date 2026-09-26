namespace Adv_3;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        SortedDictionary<int, string> leaderboard = new SortedDictionary<int, string>();

        leaderboard.Add(500, "Ahmed");
        leaderboard.Add(200, "Sara");
        leaderboard.Add(800, "Ali");
        leaderboard.Add(350, "Mona");

        Console.WriteLine("Leaderboard:");

        foreach (var player in leaderboard)
        {
            Console.WriteLine($"{player.Key} = {player.Value}");
        }

        Console.WriteLine($"\nFirst Key: {leaderboard.Keys.First()}");
        Console.WriteLine($"First Value: {leaderboard.Values.First()}");

        Console.WriteLine($"\nScore 500 exists: {leaderboard.ContainsKey(500)}");

        if (leaderboard.TryGetValue(999, out string playerName))
            Console.WriteLine($"Player with score 999: {playerName}");
        else
            Console.WriteLine("Player with score 999: Not Found");

        leaderboard.Remove(200);

        Console.WriteLine("\nLeaderboard after removing score 200:");

        foreach (var player in leaderboard)
        {
            Console.WriteLine($"{player.Key} = {player.Value}");
        }
    }
}