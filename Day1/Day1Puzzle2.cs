using System.IO;
using System.Linq;

public class Day1Puzzle2 
{
    public static void output(string inputLocation)
    {
        var importString = File.ReadAllText(inputLocation);
        var splitByElf = importString.Split("\n\n").ToList();
        List<int> elfCalories = new List<int>();
        splitByElf.ForEach(x => elfCalories.Add(x.Split().Sum(x => int.Parse(x))));
        elfCalories.Sort();
        elfCalories.Reverse();
        int top3ElvesSum = elfCalories.GetRange(0, 3).Sum();
        Console.WriteLine($"Day1Puzzlew solution: {top3ElvesSum}");
    }
}