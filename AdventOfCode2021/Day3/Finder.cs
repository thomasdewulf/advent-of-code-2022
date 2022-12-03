// ReSharper disable PossibleMultipleEnumeration
namespace Day3;

public class Finder
{
    private readonly IEnumerable<string> _baseInput;
    private readonly int _lengthOfInput;

    public Finder(string[] baseInput)
    {
        _baseInput = baseInput.ToList();
        _lengthOfInput = _baseInput.First().Length;
    }

    public string FindOxygenRating()
    {
        var workingList = _baseInput;
        for (int i = 0; i < _lengthOfInput; i++)
        {

            var charsAtIndex = workingList.Select(x => x[i]);
            var amountOfOnes = charsAtIndex.Count(x => x == 1);
            var amountOfZeroes = charsAtIndex.Count(x => x == 0);
            
            if (amountOfOnes > amountOfZeroes)
            {
                workingList = workingList.Where(x => x.StartsWith('1'));
            }
            else
            {
                workingList = workingList.Where(x => x.StartsWith('0'));
            }
        }   
    }
}