namespace Day4;

class Day4Puzzle2
{
    public static void output(string inputLocation)
    {
        var inputString = File.ReadAllText(inputLocation);
        var assignments = inputString.Split("\n");
        var assigmentsSplit = assignments.Select(x => x.Split(",").Select(y => y.Split("-")));
        var solution = assigmentsSplit
            .Where(
                    x => 
                    !(
                        (int.Parse(x.First().First()) <= int.Parse(x.Last().First())
                        &&
                        int.Parse(x.First().Last()) < int.Parse(x.Last().Last())
                        &&
                        int.Parse(x.First().First()) <= int.Parse(x.Last().Last())
                        &&
                        int.Parse(x.First().Last()) < int.Parse(x.Last().First()))
                        ||
                        (int.Parse(x.First().First()) > int.Parse(x.Last().First())
                        &&
                        int.Parse(x.First().Last()) >= int.Parse(x.Last().Last())
                        &&
                        int.Parse(x.First().First()) > int.Parse(x.Last().Last())
                        &&
                        int.Parse(x.First().Last()) >= int.Parse(x.Last().First()))
                    )
            ).Count();
        //var test3 = test.Where(x => x.Select(y => int.Parse(y.First()) > int.Parse(y.Last())));
        Console.WriteLine($"Day4Puzzle2 solution: {solution}");
    }
}