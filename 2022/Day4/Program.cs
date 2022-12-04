// See https://aka.ms/new-console-template for more information

using Day4;

var lines = await File.ReadAllLinesAsync("input.txt");

var fullOverlap = 0;
var partialOverlap = 0;
foreach (var line in lines)
{
    //Split biu , to have each elf
    var elves = line.Split(",");
    var pair = new Pair();
    var firstElf = new TaskRange(elves.First().Split("-"));
    var secondElf = new TaskRange(elves.Last().Split("-"));
    pair.Elf1 = firstElf;
    pair.Elf2 = secondElf;

    if (pair.RangesFullyOverlap())
    {
        fullOverlap++;
    }

    if (pair.PartialOverlap())
    {
        partialOverlap++;
    }
}

Console.WriteLine($"Full: {fullOverlap}");
Console.WriteLine($"Partial: {partialOverlap}");