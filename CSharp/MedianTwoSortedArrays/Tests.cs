using NUnit.Framework;

namespace MedianTwoSortedArrays;

public class Tests
{
    [Test, TestCaseSource(nameof(TestCases))]
    public double TestFindMedianSortedArrays(int[] nums1, int[] nums2) => Solution.FindMedianSortedArrays(nums1, nums2);

    public static IEnumerable<TestCaseData> TestCases()
    {
        yield return new TestCaseData(new[] { 1, 3 }, new[] { 2 }).Returns(2).SetName("01");
        yield return new TestCaseData(new[] { 1, 2 }, new[] { 3, 4 }).Returns(2.5).SetName("02");
        yield return new TestCaseData(Array.Empty<int>(), new[] { 1 }).Returns(1).SetName("03");
        yield return new TestCaseData(new[] { 1, 3 }, new[] { 2, 7 }).Returns(2.5).SetName("04");
        yield return new TestCaseData(Array.Empty<int>(), new[] { 2, 3 }).Returns(2.5).SetName("05");
    }
}