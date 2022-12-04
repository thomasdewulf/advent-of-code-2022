namespace Day4;

public class Pair
{
    public TaskRange Elf1 { get; set; }
    public TaskRange Elf2 { get; set; }


    public bool RangesFullyOverlap()
    {
        var overlapOne = Elf1.Start >= Elf2.Start && Elf1.End <= Elf2.End;
        var overlapTwo = Elf2.Start >= Elf1.Start && Elf2.End <= Elf1.End;

        return overlapOne | overlapTwo;
    }

    public bool PartialOverlap()
    {
        var fullRange1 = Enumerable.Range(Elf1.Start, Elf1.End - Elf1.Start + 1);
        var fullRange2 = Enumerable.Range(Elf2.Start, Elf2.End - Elf2.Start + 1);

        var result = fullRange1.Intersect(fullRange2);
        return result.Any();
    }
}