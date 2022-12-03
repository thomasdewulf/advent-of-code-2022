var calories = File.ReadAllText("input.txt");

var max = calories
    .Split($"{Environment.NewLine}{Environment.NewLine}")
    .Select(x =>
        x.Split(Environment.NewLine).Select(int.Parse)
            .Sum())
    .OrderByDescending(x => x)
    .Take(3)
    .Sum();

Console.WriteLine("Elf MAX");
Console.WriteLine(max);