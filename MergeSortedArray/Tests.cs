using NUnit.Framework;

namespace MergeSortedArray;

[TestFixture]
public class Tests
{
    [Test, TestCaseSource(nameof(TestCases))]
    public void TestMerge(int[] nums1, int m, int[] nums2, int n, int[] expected)
    {
        // Arrange
        // Act
        Solution.Merge(nums1, m, nums2, n);

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(nums1, Is.EquivalentTo(expected));
        });
    }

    public static IEnumerable<TestCaseData> TestCases()
    {
        yield return new TestCaseData(new[] { 1, 2, 3, 0, 0, 0 }, 3, new[] { 2, 5, 6 }, 3, new[] { 1, 2, 2, 3, 5, 6 }).SetName("01");
        yield return new TestCaseData(new[] { 1 }, 1, Array.Empty<int>(), 0, new[] { 1 }).SetName("02");
        yield return new TestCaseData(new[] { 0 }, 0, new[] { 1 }, 1, new[] { 1 }).SetName("03");
        yield return new TestCaseData(new[] { 4, 5, 6, 0, 0, 0 }, 3, new[] { 1, 2, 3 }, 3, new[] { 1 ,2, 3, 4, 5, 6 }).SetName("04");
    }
}