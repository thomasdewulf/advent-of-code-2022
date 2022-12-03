namespace Day3;

public static class Extensions
{
    private const string BaseAlphabet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";

    public static int GetPriority(this char value)
    {
        return BaseAlphabet.IndexOf(value) + 1;
    }
}