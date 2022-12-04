namespace Day4;

public class TaskRange
{
    public TaskRange(string[] value)
    {
        Start = int.Parse(value[0]);
        End = int.Parse(value[1]);
    }
    public int Start { get; set; }
    
    public int End { get; set; }
}