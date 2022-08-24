namespace PowerOfThree;

// 326. Power of Three
internal static class Solution
{
    public static bool IsPowerOfThree(int n)
    {
        var log = Math.Log(n, 3);
        var rounded = Math.Round(log);

        return Math.Abs(rounded - log) < 1e-10;
    } 
}