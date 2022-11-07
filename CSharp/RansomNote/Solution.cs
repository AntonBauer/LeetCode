namespace RansomNote;

// 383. Ransom Note
internal static class Solution
{
    public static bool CanConstruct(string ransomNote, string magazine)
    {
        var ransomMap = ConstructMap(ransomNote);
        var magMap = ConstructMap(magazine);

        return ransomMap.All(pair => magMap.ContainsKey(pair.Key) && magMap[pair.Key] >= pair.Value);
    }

    private static Dictionary<char, int> ConstructMap(string str)
    {
        var map = new Dictionary<char, int>();
        
        foreach (var letter in str)
        {
            if (!map.ContainsKey(letter))
                map.Add(letter, 1);
            else
                map[letter]++;
        }

        return map;
    }
}