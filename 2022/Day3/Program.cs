using Day3;

var input = await File.ReadAllLinesAsync("input.txt");

// PART 1
var prios = input.
Select(x => new Rucksack(x)
        .GetPriority())
    .Sum();

Console.WriteLine(prios);

// PART 2
var result = input.Chunk(3) //Group rucksacks per 3 elves
    .Select(rucksacks => rucksacks
    .Aggregate<IEnumerable<char>>((previousList, nextList) => 
        previousList.
            Intersect(nextList)) //Intersect the 3 rucksack values to get the common value
    .Single()) //There should only be one common value
    .Select(x => x.GetPriority()) // Get the prio of that value
    .Sum(); // Add upp all the prios to get final prio

Console.WriteLine(result);

