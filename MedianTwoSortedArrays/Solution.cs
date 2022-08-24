namespace MedianTwoSortedArrays;

// 4. Median of Two Sorted Arrays
internal static class Solution
{
    public static double FindMedianSortedArrays(int[] nums1, int[] nums2) => Median(MergeArrays(nums1, nums2));

    private static int[] MergeArrays(int[] nums1, int[] nums2)
    {
        var result = new int[nums1.Length + nums2.Length];

        var resultPosition = 0;
        var firstPosition = 0;
        var secondPosition = 0;

        while (resultPosition < result.Length)
        {
            if (firstPosition == nums1.Length)
            {
                result[resultPosition] = nums2[secondPosition];
                ++secondPosition;
            }
            else if (secondPosition == nums2.Length)
            {
                result[resultPosition] = nums1[firstPosition];
                ++firstPosition;
            }
            else if (nums1[firstPosition] > nums2[secondPosition])
            {
                result[resultPosition] = nums2[secondPosition];
                ++secondPosition;
            }
            else
            {
                result[resultPosition] = nums1[firstPosition];
                ++firstPosition;
            }

            ++resultPosition;
        }

        return result;
    }

    private static double Median(int[] nums)
    {
        switch (nums.Length)
        {
            case 1:
                return nums[0];
            default:
            {
                var middle = nums.Length / 2;

                return middle * 2 == nums.Length
                    ? (nums[middle - 1] + nums[middle]) / 2d
                    : nums[middle];
            }
        }
    }
}