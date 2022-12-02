// See https://aka.ms/new-console-template for more information

var calories = File.ReadAllText("input.txt");

var max = calories
    .Split($"{Environment.NewLine}{Environment.NewLine}")
    .Select(x => 
        x.Split(Environment.NewLine).Select(int.Parse)
            .Sum())
    .Max();


    Console.WriteLine("Elf MAX");
    Console.WriteLine(max);

    

