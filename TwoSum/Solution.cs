namespace TwoSum;

internal static class Solution
{
    public static int[] TwoSum(int[] nums, int target)
    {
        var numbersMap = new Dictionary<int, int>();

        for (var i = 0; i < nums.Length; i++)
        {
            var diff = target - nums[i];
            if (numbersMap.ContainsKey(diff))
                return new[] { numbersMap[diff], i };

            if (!numbersMap.ContainsKey(nums[i]))
                numbersMap.Add(nums[i], i);
        }

        return Array.Empty<int>();
    }
}