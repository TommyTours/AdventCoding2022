using System.IO;
using System.Linq;

public class Day1Puzzle1 
{
    public static void output(string inputLocation)
    {
        var importString = File.ReadAllText(inputLocation);
        var splitByElf = importString.Split("\n\n").ToList();
        List<int> elfCalories = new List<int>();
        splitByElf.ForEach(x => elfCalories.Add(x.Split().Sum(x => int.Parse(x))));
        Console.WriteLine($"Day1Puzzle1 solution: {elfCalories.Max().ToString()}");
    }
}