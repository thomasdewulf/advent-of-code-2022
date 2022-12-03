namespace Dayy2;

public class Position
{
    public int X { get; set; }
    public int Y { get; set; }
    public int Aim { get; set; }

    public void Move(Instruction instruction)
    {
        switch (instruction.Command)
        {
            case "forward":
                X += instruction.Value;
                Y += Aim * instruction.Value;
                break;
            case "up":
                Aim -= instruction.Value;
                break;
            case "down":
                Aim += instruction.Value;
                break;
            default: throw new ArgumentException("Unsupported command");
        }
    }
}