﻿namespace MergeSortedArray;

// 88. Merge Sorted Array
internal static class Solution
{
    public static void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        var first = 0;
        var second = 0;
        var inserted = 0;

        while (second < n)
        {
            if (nums2[second] < nums1[first] || first >= m + inserted)
            {
                ShiftRight(nums1, first);
                nums1[first] = nums2[second];
                ++second;
                ++inserted;
            }
            else
                ++first;
        }
    }

    private static void ShiftRight(int[] array, int index)
    {
        for (var i = array.Length - 1; i > index; i--)
        {
            array[i] = array[i - 1];
            array[i - 1] = 0;
        }
    }
}