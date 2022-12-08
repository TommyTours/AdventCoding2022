namespace Day5;

class Day5Puzzle1
{
    public static void output(string inputLocation)
    {
        var inputString = File.ReadAllText(inputLocation);
        var split = inputString.Split("\n\n");
        List<string> crates = split[0].Split("\n").ToList().SkipLast(1).ToList();
        var piles = Helpers.parseCrates(crates);
        var instructions = split[1].Split("\n");
        foreach(var instruction in instructions)
        {
            doInstruction(piles, instruction);
        }
        string output = "";
        foreach(var pile in piles)
        {
            output += pile.Peek();
        }
        output = output.Replace("[", "");
        output  =output.Replace("]", "");
        Helpers.printPiles(piles);
        Console.WriteLine($"Day5 Puzzle1 solution : {output}");
    }

    public static void doInstruction(List<Stack<string>> piles, string instruction)
    {
        var instructionSplit = instruction.Split(" ");
        int moveNumber = int.Parse(instructionSplit[1]);
        int fromPile = int.Parse(instructionSplit[3]);
        int toPile = int.Parse(instructionSplit[5]);
        for(int i = 0; i < moveNumber; i++)
        {
            var item = piles[fromPile - 1].Pop();
            piles[toPile - 1].Push(item);
        }
    }

   
}