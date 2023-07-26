using NUnit.Framework;

namespace MergeTwoSortedLists;

[TestFixture]
public class Tests
{
    [Test, TestCaseSource(nameof(TestCases))]
    public int[] MergeTwoSortedListsTests(int[] list1, int[] list2) =>
        Solution.MergeTwoLists(list1.ToListNode(), list2.ToListNode()).ToArray();

    public static IEnumerable<TestCaseData> TestCases()
    {
        yield return new TestCaseData(new[] { 1, 2, 4 }, new[] { 1, 3, 4 }).Returns(new[] { 1, 1, 2, 3, 4, 4 })
                                                                           .SetName("01");
        yield return new TestCaseData(Array.Empty<int>(), Array.Empty<int>()).Returns(Array.Empty<int>()).SetName("02");
        yield return new TestCaseData(Array.Empty<int>(), new[] { 0 }).Returns(new[] { 0 }).SetName("03");
    }
}