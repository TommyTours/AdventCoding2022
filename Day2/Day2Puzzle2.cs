namespace Day2;

class Day2Puzzle2 
{
    public static void output(string inputLocation)
    {
        var inputString = File.ReadAllText(inputLocation);
        var stratGuideSplit = inputString.Split("\n");
        var rock = stratGuideSplit.Select(game => game.Split()).Where(x => x.First() == "A");
        var paper = stratGuideSplit.Select(game => game.Split()).Where(x => x.First() == "B");
        var scissors = stratGuideSplit.Select(game => game.Split()).Where(x => x.First() == "C");
        int score = 0;
        score += rock.Where(x => x.Last() == "X").Count() * 3;
        score += rock.Where(x => x.Last() == "Y").Count() * 4;
        score += rock.Where(x => x.Last() == "Z").Count() * 8;
        score += paper.Where(x => x.Last() == "X").Count() * 1;
        score += paper.Where(x => x.Last() == "Y").Count() * 5;
        score += paper.Where(x => x.Last() == "Z").Count() * 9;
        score += scissors.Where(x => x.Last() == "X").Count() * 2;
        score += scissors.Where(x => x.Last() == "Y").Count() * 6;
        score += scissors.Where(x => x.Last() == "Z").Count() * 7;

        Console.WriteLine($"Day2Puzzle1 Solution: {score}");
    }
}