// See https://aka.ms/new-console-template for more information

var input = await File.ReadAllLinesAsync("input.txt");

var inputParsed = input.Select(int.Parse).ToArray();

var changes = new List<int>();


for (int i = 2; i < inputParsed.Length; i++)
{

    var current = inputParsed[i];
    var middle = inputParsed[i - 1];
    var first = inputParsed[i - 2];

    var firstWindow = first + middle + current;

    if (i + 1 >= inputParsed.Length)
    {
        break;
    }
    current = inputParsed[i + 1];
    middle = inputParsed[i];
    first = inputParsed[i - 1];

    var secondWindow = first + middle + current;

    var change = secondWindow - firstWindow;
    changes.Add(change);
}

Console.WriteLine(changes.Count(x => x > 0));

