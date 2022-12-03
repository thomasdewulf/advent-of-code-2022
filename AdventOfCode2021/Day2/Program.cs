// See https://aka.ms/new-console-template for more information

using Dayy2;

var input = await File.ReadAllLinesAsync("input.txt");

var instructions = input.Select(x =>
{
    var split = x.Split(" ");
    return new Instruction(split[0], int.Parse(split[1]));
});

var position = new Position();

foreach (var instruction in instructions)
{
    position.Move(instruction);
}

var final = position.X * position.Y;

Console.WriteLine(final);

