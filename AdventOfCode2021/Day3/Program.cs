// See https://aka.ms/new-console-template for more information

using System.Text;

var lines  = (await File.ReadAllLinesAsync("input.txt"));

var lengthOfLine = lines[0].Length;
var fullGamma = new StringBuilder();
var fullEpsilon = new StringBuilder();
for (int i = 0; i < lengthOfLine; i++)
{
    var gammaForColumn = GetGammaForColumn(i);
    fullEpsilon.Append(gammaForColumn == 1 ?  0 : 1);
    fullGamma.Append(gammaForColumn);
}

Console.WriteLine(fullGamma.ToString());
Console.WriteLine(fullEpsilon.ToString());

var result = Convert.ToInt32(fullGamma.ToString(),2) * Convert.ToInt32(fullEpsilon.ToString(), 2);

Console.WriteLine(result);


int GetGammaForColumn(int index)
{
    var ones = 0;
    var zeroes = 0;
    foreach (var line in lines)
    {
        var itemAtIndex = int.Parse(line[index].ToString());
        switch (itemAtIndex)
        {
            case 1: ones++;
                break;
            case 0: zeroes++;
                break;
            default: throw new ArgumentException("Only one or zero expected");
        }
        
    }

    return ones > zeroes ? 1 : 0;
}