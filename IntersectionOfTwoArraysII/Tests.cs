using NUnit.Framework;

namespace IntersectionOfTwoArraysII;

[TestFixture]
public class Tests
{
    [Test, TestCaseSource(nameof(TestCases))]
    public int[] TestIntersect(int[] nums1, int[] nums2) => Solution.Intersect(nums1, nums2);

    public static IEnumerable<TestCaseData> TestCases()
    {
        yield break;
    }
}