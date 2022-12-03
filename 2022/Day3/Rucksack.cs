namespace Day3;

public class Rucksack
{
    private const string _baseAlphabet = "abcdefghijklmnopqrstuvwxyz";
    private string _alphabetWithUpper;

    public Rucksack(string value)
    {
        var halved = value.Chunk(value.Length / 2).Select(x => new string(x));
        CompartmentOne = halved.First();
        CompartmentTwo = halved.Last();
        _alphabetWithUpper = $"{_baseAlphabet}{_baseAlphabet.ToUpper()}";
    }

    public string CompartmentOne { get; set; }
    public string CompartmentTwo { get; set; }

    public int GetPriority()
    {
        var common = CompartmentOne.Intersect(CompartmentTwo).Distinct().Single();
        return _alphabetWithUpper.IndexOf(common) + 1;
    }
}