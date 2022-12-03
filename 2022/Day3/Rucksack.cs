namespace Day3;

public class Rucksack
{
    private readonly string _compartmentOne;
    private readonly string _compartmentTwo;
    public Rucksack(string value)
    {
        var halved = value.Chunk(value.Length / 2).Select(x => new string(x));
        _compartmentOne = halved.First();
        _compartmentTwo = halved.Last();
    }
    
    public int GetPriority()
    {
        var common = _compartmentOne.Intersect(_compartmentTwo).Distinct().Single();
        return common.GetPriority();
    }
}