namespace Day6;

class Day6Puzzle
{
    public static void output(string inputLocation, int puzzleNumber)
    {
        var inputString = File.ReadAllText(inputLocation);
        var mainQueue = parseInput(inputString);
        var checking = new Queue<char>();
        int lengthOfCode = puzzleNumber == 1 ? 4 : 14;
        for (int i = 0; i < lengthOfCode; i++)
        {
            checking.Enqueue(mainQueue.Dequeue());
        }
        var alreadyChecked = new Queue<char>();
        while (checking.Distinct().Count() < lengthOfCode)
        {
            alreadyChecked.Enqueue(checking.Dequeue());
            checking.Enqueue(mainQueue.Dequeue());
        }
        int solution = alreadyChecked.Count() + lengthOfCode;
        Console.WriteLine($"Day 6 Puzzle 1 Solution: {solution}");
    }
    public static Queue<char> parseInput(string inputString)
    {
        Queue<char> inputQueue = new Queue<char>();
        foreach (var character in inputString)
        {
            inputQueue.Enqueue(character);
        }
        return inputQueue;
    }
}