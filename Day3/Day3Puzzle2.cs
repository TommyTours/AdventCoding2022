namespace Day3;

class Day3Puzzle2 
{
    public static void output(string inputLocation)
    {
         var inputString = File.ReadAllText(inputLocation);
        var rucksacks = inputString.Split("\n");
        var groups = rucksacks.Select((x, i) => new { Index = i, Value = x })
        .GroupBy(x => x.Index / 3)
        .Select(x => x.Select(v => v.Value).ToList())
        .ToList();
        var badges = groups.Select(x => x.Select(y => y).First().Intersect(x.ElementAt(1).Intersect(x.ElementAt(2))).First());
        var priorities = badges.Select(x => Helpers.getPriority(x.ToString()));
        Console.WriteLine($"Day3Puzzle1 solution: {priorities.Sum()}");
    }
}