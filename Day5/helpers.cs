 
using System.Text.RegularExpressions;

namespace Day5;

class Helpers
{
    public static List<Stack<String>> parseCrates(List<string> crates)
    {
        int numberOfPiles = (crates.First().Length + 1) / 4;
        List<Stack<string>> piles = new List<Stack<string>>();
        for (int i = 0; i < numberOfPiles; i++)
        {
            piles.Add(new Stack<string>());
        }
        for (int i = crates.Count - 1; i >= 0; i--)
        {
            var level = crates.ElementAt(i) + " ";
            var split = Regex.Split(level, @"(?<=\G.{4})").SkipLast(1);
            for (int x = 0; x < split.Count(); x++)
            {
                if (split.ElementAt(x) != "    ")
                {
                    piles.ElementAt(x).Push(split.ElementAt(x).TrimEnd(' '));
                }
            }
        }
        return piles;
    }

    public static void printPiles(List<Stack<string>> piles)
    {
        int numberOfPiles = piles.Count;
        int highestPoint = piles.Max(x => x.Count);
        string output = "";
        foreach (var pile in piles)
        {
            if (pile.Count < highestPoint)
            {
                int startCount = pile.Count;
                for (int i = 0; i < highestPoint - startCount; i++)
                {
                    pile.Push("   ");
                }
            }
        }
        for (int i = 0; i < highestPoint; i++)
        {
            foreach (var pile in piles)
            {
                output += pile.ElementAt(i) + " ";
            }
            output += "\n";
        }
        foreach(var pile in piles)
        {
            int pileCount = pile.Count;
            for(int i = 0; i < pileCount; i++)
            {
                if(pile.Count == 0 || pile.Peek() != "   ")
                {
                    break;
                }
                pile.Pop();
            }
        }
        Console.WriteLine("\n" + output);
        // string test = "";
        // for(int x = highestPoint -1; x >= 0; x--)
        // {
        //     foreach(var pile in piles)
        //     {
        //         if (pile.Count < x + 1)
        //         {
        //             test += "    ";
        //         }
        //         else
        //         {
        //             if(x == highestPoint - 1)
        //             {
        //                 test += pile.ElementAt(0) + " ";
        //             }
        //             else if (x == 0)
        //             {
        //                 test += pile.ElementAt(highestPoint - 1) + " ";
        //             }
        //             else
        //             {
        //                 test += pile.ElementAt((highestPoint-1) - (x%(highestPoint-1))) + " ";
        //             }
        //         }
        //     }
        //     test += "\n";
        // }
    }
}