namespace Dayy2;

public class Instruction
{
    public Instruction(string command, int value)
    {
        Command = command;
        Value = value;
    }
    public string Command { get; set; }
    public int Value { get; set; }
    
}