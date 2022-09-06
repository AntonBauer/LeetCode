namespace LongestSubstringWithoutRepeatingCharacters;

// 3. Longest Substring Without Repeating Characters
internal static class Solution
{
    public static int LengthOfLongestSubstring(string s) =>
        s.Length switch
        {
            0 => 0,
            1 => 1,
            _ => CalcLongestSubstring(s)
        };

    private static int CalcLongestSubstring(string s)
    {
        var charsMap = new Dictionary<char, int>();
        var length = 0;

        var firstPointer = 0;
        var secondPointer = 0;

        while (secondPointer < s.Length)
        {
            if (!charsMap.TryAdd(s[secondPointer], secondPointer))
            {
                firstPointer = charsMap[s[firstPointer]] + 1;
                charsMap[s[secondPointer]] = secondPointer;
            }

            length = Math.Max(length, secondPointer - firstPointer + 1);
            ++secondPointer;
        }
        
        return length;
    }
}