using Day2;


var lines = File.ReadAllLines("input.txt");

var rounds = lines.Select(x =>
{
    var split = x.Split(" ");
    var round = new Round(split[0][0], split[1][0]);
    return round;
});

var totalScore = 0;
foreach (var round in rounds)
{
    var score = round.GetScorePlayer2();
    totalScore += score;
    Console.WriteLine($"Round score: {score}");
    Console.WriteLine("---------------");
}

Console.WriteLine($"Total score: {totalScore}");