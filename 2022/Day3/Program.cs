using Day3;

var input = await File.ReadAllLinesAsync("input.txt");

// PART 1
var prios = input.
Select(x => new Rucksack(x)
        .GetPriority())
    .Sum();

Console.WriteLine(prios);

// PART 2
var chunked = input.Chunk(3);

var result = new List<char>();
foreach (var rucksacks in chunked)
{
    var first = rucksacks[0];
    var second = rucksacks[1];
    var third = rucksacks[2];

    var common = first.Intersect(second).Intersect(third).Single();

    result.Add(common);
}

Console.WriteLine(result.Select(x => x.GetPriority()).Sum());

