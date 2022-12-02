namespace Day2;

class Day2Puzzle1 
{
    public static void output(string inputLocation)
    {
        var inputString = File.ReadAllText(inputLocation);
        var stratGuideSplit = inputString.Split("\n");
        var rock = stratGuideSplit.Select(game => game.Split()).Where(x => x.Last() == "X");
        var paper = stratGuideSplit.Select(game => game.Split()).Where(x => x.Last() == "Y");
        var scissors = stratGuideSplit.Select(game => game.Split()).Where(x => x.Last() == "Z");
        int score = rock.Count() + (paper.Count() * 2) + (scissors.Count() * 3);
        score += rock.Where(x => x.First() == "A").Count() * 3;
        score += rock.Where(x => x.First() == "C").Count() * 6;
        score += paper.Where(x => x.First() == "B").Count() * 3;
        score += paper.Where(x => x.First() == "A").Count() * 6;
        score += scissors.Where(x => x.First() == "C").Count() * 3;
        score += scissors.Where(x => x.First() == "").Count() * 6;

        Console.WriteLine($"Day2Puzzle1 Solution: {score}");
    }
}