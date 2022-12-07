namespace Day3;

class Helpers 
{
    public static int getPriority(string item)
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