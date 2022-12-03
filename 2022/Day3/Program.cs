// See https://aka.ms/new-console-template for more information

using System.Text.Json;
using System.Text.Json.Serialization;
using Day3;

var input = await File.ReadAllLinesAsync("input.txt");

var chunked = input.
Select(x => new Rucksack(x)
        .GetPriority())
    .Sum();

Console.WriteLine(chunked);

