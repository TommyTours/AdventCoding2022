namespace Day3;

class Day3Puzzle1 
{
    public static void output(string inputLocation)
    {
        // string string1 = "qwertty";
        // string string2 = "poiuyt";
        // var inbothstrings = string1.Intersect(string2);
        var inputString = File.ReadAllText(inputLocation);
        var rucksacks = inputString.Split("\n");
        var firstHalfs = rucksacks.Select(x => x.Substring(0, x.Length/ 2)).ToList();
        var secondHalfs = rucksacks.Select(x => x.Substring(x.Length / 2)).ToList();
        var sharedItems = firstHalfs.Select(x => x.Where(y => secondHalfs.ElementAt(firstHalfs.IndexOf(x)).Contains(y)).Distinct()).ToList();
        // var listOfLists1stHalf = firstHalfs.Select(x => x.Select(y => y));
        // var listOfLists2ndHalf = secondHalfs.Select(x => x.Select(y => y));
        // var listOfLists1stHalfDistinct = listOfLists1stHalf.Select(x => x.Distinct().ToList());
        // var listOfLists2ndHalfDistinct = listOfLists2ndHalf.Select(x => x.Distinct().ToList());
        // //var test =  listOfLists1stHalfDistinct.Select(x => x.Select(y => y).ToList().Intersect(listOfLists2ndHalfDistinct.Select(z => z.Select(w => w))));
        // var test2 = listOfLists1stHalf.Where(x => x.Select(z => z).Any() == listOfLists2ndHalf.Select(y => y).Any());
        // var test3 = firstHalfs.Where(x => secondHalfs.Select(y => y).Any(y => x.Contains(y)));
        var priorities = sharedItems.Select(x => getPriority(x.First().ToString()));
        Console.WriteLine($"Day3Puzzle1 solution: {priorities.Sum()}");
    }

    private static int getPriority(string item)
    {
        if(item.ToUpper() == item)
        {
            return (int)item.First() - 38;
        }
        else 
        {
            return (int)item.First() - 96;
        }
    }
}